using System;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            // Part 1: Variable Declarations
            int myInt = 25;
            double myDouble = 10.5;
            float myFloat = 5.75f;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Hello, C#!";

            Console.WriteLine("int: " + myInt);
            Console.WriteLine("double: " + myDouble);
            Console.WriteLine("float: " + myFloat);
            Console.WriteLine("char: " + myChar);
            Console.WriteLine("bool: " + myBool);
            Console.WriteLine("string: " + myString);

            // Part 2: Type Casting
            double castDouble = 9.78;
            int castInt = (int)castDouble;
            Console.WriteLine("Explicit cast (double to int): " + castInt);

            string intToString = Convert.ToString(myInt);
            string boolToString = Convert.ToString(myBool);
            Console.WriteLine("Converted int to string: " + intToString);
            Console.WriteLine("Converted bool to string: " + boolToString);

            // Part 3: User Input and Type Conversion
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + userName + "! You are " + userAge + " years old.");

            // Part 4: Arithmetic Operators
            int num1 = 10, num2 = 5;
            Console.WriteLine("Addition (+10): " + (num1 + 10));
            Console.WriteLine("Subtraction (-2): " + (num1 - 2));
            Console.WriteLine("Multiplication (*3): " + (num1 * 3));
            Console.WriteLine("Division (/2): " + (num1 / 2));
            Console.WriteLine("Modulus (%2): " + (num1 % 2));

            // Part 5: Floating Point Precision
            float floatValue = 1.123456789f;
            double doubleValue = 1.123456789;
            Console.WriteLine("Float value: " + floatValue);
            Console.WriteLine("Double value: " + doubleValue);

            // Part 6: Increment and Decrement
            int counter = 10;
            counter++;
            Console.WriteLine("After increment: " + counter);
            counter--;
            Console.WriteLine("After decrement: " + counter);
        }
    }
}
