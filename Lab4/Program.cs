namespace Lab4;

using System;

class Program
{
    static void Main()
    {
        // Problem 1
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        // Problem 2
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();

        // Problem 3
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        Console.WriteLine();

        // Problem 4
        int number;
        do
        {
            Console.Write("Enter a number greater than 100: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number <= 100);

        Console.WriteLine();

        // Problem 5
        int mult = 10;
        while (mult <= 1000)
        {
            Console.WriteLine(mult);
            mult += 10;
        }

        Console.WriteLine();

        // Problem 6
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
