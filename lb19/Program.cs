using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть рядок (слова через пробіл):");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Рядок порожній!");
            return;
        }
        string[] words = input.Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var wordGroups = words
            .GroupBy(w => w.ToLower())   
            .Where(g => g.Count() > 1);

        Console.WriteLine("\nОднакові слова та їх кількість:");

        if (!wordGroups.Any())
        {
            Console.WriteLine("Однакових слів немає.");
        }
        else
        {
            foreach (var group in wordGroups)
            {
                Console.WriteLine($"Слово \"{group.Key}\" зустрічається {group.Count()} раз(и)");
            }
        }

        Console.WriteLine("\nВведіть слово, яке потрібно видалити:");
        string wordToRemove = Console.ReadLine();

        string[] filteredWords = words
            .Where(w => !w.Equals(wordToRemove, StringComparison.OrdinalIgnoreCase))
            .ToArray();

        string result = string.Join(" ", filteredWords);

        Console.WriteLine("\nРядок після видалення:");
        Console.WriteLine(result);
    }
}