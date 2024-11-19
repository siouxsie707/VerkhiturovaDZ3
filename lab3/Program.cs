using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание номер 1");
        try
        {
            Console.Write("Введите номер дня в году (1-365): ");
            int dayOfYear = int.Parse(Console.ReadLine());

            if (dayOfYear < 1 || dayOfYear > 365)
            {
                throw new ArgumentOutOfRangeException("Число должно быть в диапазоне от 1 до 365");
            }

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, 1, 1).AddDays(dayOfYear - 1);
            Console.WriteLine($"Дата: {date.Day} {GetMonthName(date.Month)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод");
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
        switch (month)
        {
            case 1: return "Январь";
            case 2: return "Февраль";
            case 3: return "Март";
            case 4: return "Апрель";
            case 5: return "Май";
            case 6: return "Июнь";
            case 7: return "Июль";
            case 8: return "Август";
            case 9: return "Сентябрь";
            case 10: return "Октябрь";
            case 11: return "Ноябрь";
            case 12: return "Декабрь";
            default: throw new ArgumentOutOfRangeException("Некорректный ввод");
        }
    }
}