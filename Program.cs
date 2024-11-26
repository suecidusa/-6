using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Запрос даты от пользователя
        Console.Write("Введите дату в формате 'ГГГГ-ММ-ДД': ");
        string userInputDate = Console.ReadLine();

        // Использование Parse()
        try
        {
            DateTime parsedDate = DateTime.Parse(userInputDate);
            Console.WriteLine($"дата: {parsedDate}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты.");
        }

        // Запрос числа от пользователя
        Console.Write("Введите целое число: ");
        string userInputNumber = Console.ReadLine();

        // Использование TryParse()
        if (int.TryParse(userInputNumber, out int parsedNumber))
        {
            Console.WriteLine($"Успешно разобрано число: {parsedNumber}");
        }
        else
        {
            Console.WriteLine("Не удалось разобрать число.");
        }

        Console.Write("Введите дату в формате 'ДД-ММ-ГГГГ': ");
        string userInputExactDate = Console.ReadLine();

        // Использование ParseExact()
        try
        {
            DateTime exactParsedDate = DateTime.ParseExact(userInputExactDate, "ДД-ММ-ГГГГ", CultureInfo.InvariantCulture);
            Console.WriteLine($"дата: {exactParsedDate}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты.");
        }

        // Запрос даты с точным форматом
        Console.Write("Введите дату в формате 'ММ-ДД-ГГГГ': ");
        string userInputAnotherExactDate = Console.ReadLine();

        // Использование TryParseExact() для даты
        if (DateTime.TryParseExact(userInputAnotherExactDate, "ММ-ДД-ГГГГ", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime anotherExactParsedDate))
        {
            Console.WriteLine($"Успешно разобрано еще одна дата: {anotherExactParsedDate}");
        }
        else
        {
            Console.WriteLine("Не удалось разобрать еще одну дату.");
        }
    }
}
