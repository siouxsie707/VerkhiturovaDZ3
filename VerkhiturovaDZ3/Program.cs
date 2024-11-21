using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Задача 1
        CheckSortedSequence();

        // Задача 2
        CheckCardValue();

        // Задача 3
        GetDrinkByProfession();

        // Задача 4
        PrintDayOfWeek();

        // Задача 5
        CountDollsInBag();
    }

    // Задача 1
    static void CheckSortedSequence()
    {
        Console.WriteLine("Задача 1. Последовательность чисел");
        int[] numbers = new int[10];
        Console.WriteLine("Введите 10 чисел(каждое число с новой строки):");
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                Console.WriteLine($"Последовательность не упорядочена по возрастанию, последовательность нарушает {i + 1} (число {numbers[i]} > {numbers[i + 1]})");
                break;
            }
            if (i == numbers.Length - 2)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
        }
    }

    // Задача 2
    static void CheckCardValue()
    {
        try
        {
            Console.WriteLine("Задача 2. Определение достоинства карт");
            Console.Write("Введите номер карты (6-14): ");
            int k = int.Parse(Console.ReadLine());
            string cardValue;

            switch (k)
            {
                case 6: cardValue = "Шестерка"; break;
                case 7: cardValue = "Семёрка"; break;
                case 8: cardValue = "Восьмёрка"; break;
                case 9: cardValue = "Девятка"; break;
                case 10: cardValue = "Десятка"; break;
                case 11: cardValue = "Валет"; break;
                case 12: cardValue = "Дама"; break;
                case 13: cardValue = "Король"; break;
                case 14: cardValue = "Туз"; break;
                default:
                    throw new ArgumentOutOfRangeException("Номер карты должен быть между 6 и 14.");
            }

            Console.WriteLine($"Достоинство карты: {cardValue}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Число введено не верно.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Задание 2 завершено");
        }
    }

    // Задача 3
    static void GetDrinkByProfession()
    {
        Console.WriteLine("Задача 3. Таблица");
        Console.Write("Введите профессию: ");
        string input = Console.ReadLine()?.ToLowerInvariant();
        string output;

        switch (input)
        {
            case "jabroni":
                output = "Patron Tequila";
                break;
            case "school counselor":
                output = "Anything with Alcohol";
                break;
            case "programmer":
                output = "Hipster Craft Beer";
                break;
            case "bike gang member":
                output = "Moonshine";
                break;
            case "politician":
                output = "Your tax dollars";
                break;
            case "rapper":
                output = "Cristal";
                break;
            default:
                output = "Beer";
                break;
        }

        Console.WriteLine(output);
    }

    // Задача 4
    enum DaysOfWeek
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    static void PrintDayOfWeek()
    {
        Console.WriteLine("Задача 4. Название дня недели по его номеру");
        Console.Write("Введите номер дня недели (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine()); if (Enum.IsDefined(typeof(DaysOfWeek), dayNumber))
        {
            DaysOfWeek day = (DaysOfWeek)dayNumber;
            Console.WriteLine($"День недели: {day}");
        }
        else
        {
            Console.WriteLine("Введите номер от 1 до 7.");
        }
    }

    // Задача 5
    static void CountDollsInBag()
    {
        Console.WriteLine("Задача 5. Подсчет кукол");
        string[] dollsArray = { "Hello Kitty", "Barbie doll", "Teddy Bear", "Action Figure", "Dollhouse" };
        List<string> bag = new List<string>();

        foreach (string doll in dollsArray)
        {
            if (doll == "Hello Kitty" || doll == "Barbie doll")
            {
                bag.Add(doll);
            }
        }

        Console.WriteLine($"Кукол в 'сумке': {bag.Count}");
    }
}