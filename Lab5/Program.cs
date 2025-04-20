using System;

class Program
{
    static void Main()
    {
        // Problem 1: Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine($"Season: {season}");
        }

        Console.WriteLine(); // Separator

        // Problem 2: Days of the Week (1–7)
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        if (int.TryParse(Console.ReadLine(), out int inputDay) && inputDay >= 1 && inputDay <= 7)
        {
            Console.WriteLine($"That day is: {days[inputDay - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }

        Console.WriteLine(); // Separator

        // Problem 3: Favorite Books and Authors
        string[] books = { "The Hobbit", "Charlotte’s Web", "1984" };
        string[] authors = { "J.R.R. Tolkien", "E.B. White", "George Orwell" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        Console.WriteLine(); // Separator

        // Problem 4: Temperature Tracker
        int[] temperatures = { 65, 72, 78, 70, 68 };
        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures: ");
        foreach (int temp in temperatures)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine($"\nHighest Temperature: {temperatures[^1]}");
        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");

        Console.WriteLine(); // Separator

        // Problem 5: Reverse Countdown
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        Console.Write("Countdown: ");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(countdown[i] + " ");
        }
    }
}
