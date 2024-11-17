using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите номер дня в году (1-365): ");
            int dayOfYear = int.Parse(Console.ReadLine());

            if (dayOfYear < 1 || dayOfYear > 365)
            {
                throw new ArgumentOutOfRangeException("Число должно быть в диапазоне от 1 до 365.");
            }

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            // Определяем, является ли год високосным
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // Количество дней в каждом месяце
            int[] daysInMonth = isLeapYear
                ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
                : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int month = 0;

            // Определяем месяц и день
            for (int i = 0; i < daysInMonth.Length; i++)
            {
                if (dayOfYear <= daysInMonth[i])
                {
                    month = i + 1;
                    int day = dayOfYear; // Находим день
                    Console.WriteLine($"Дата: {day} {GetMonthName(month)}");
                    return;
                }
                dayOfYear -= daysInMonth[i];
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод, убедитесь что вы вводите число.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }

    static string GetMonthName(int month)
    {
        string[] monthNames = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        return monthNames[month - 1];
    }
}