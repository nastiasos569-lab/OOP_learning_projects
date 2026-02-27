using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("ОДНОВИМІРНИЙ МАСИВ");

        Console.Write("Введіть кількість елементів: ");
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        int positiveCount = 0;
        foreach (double x in arr)
        {
            if (x > 0)
                positiveCount++;
        }

        Console.WriteLine($"Кількість додатних елементів: {positiveCount}");
        int lastZeroIndex = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                lastZeroIndex = i;
        }

        double sumAfterZero = 0;

        if (lastZeroIndex != -1)
        {
            for (int i = lastZeroIndex + 1; i < arr.Length; i++)
            {
                sumAfterZero += arr[i];
            }
        }

        Console.WriteLine($"Сума елементів після останнього нуля: {sumAfterZero}");

        double[] newArr = new double[n];
        int index = 0;

      
        foreach (double x in arr)
        {
            if (Math.Truncate(x) <= 1)
                newArr[index++] = x;
        }

      
        foreach (double x in arr)
        {
            if (Math.Truncate(x) > 1)
                newArr[index++] = x;
        }

        Console.WriteLine("Перетворений масив:");
        foreach (double x in newArr)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

  

        Console.WriteLine("ДВОВИМІРНИЙ МАСИВ");

        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

      
        Console.WriteLine("Увесь масив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        if (rows >= 5)
        {
            Console.WriteLine("П'ятий рядок:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[4, j] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("У масиві менше 5 рядків.");
        }

       
        Console.Write("Введіть номер стовпця s (з 1): ");
        int s = int.Parse(Console.ReadLine());

        if (s >= 1 && s <= cols)
        {
            Console.WriteLine($"{s}-й стовпець:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(matrix[i, s - 1]);
            }
        }
        else
        {
            Console.WriteLine("Такого стовпця не існує.");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}