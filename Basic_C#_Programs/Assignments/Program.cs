using System;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // Call each method and display the result
            Console.WriteLine("Double: " + math.Double(number));
            Console.WriteLine("Square: " + math.Square(number));
            Console.WriteLine("Add 100: " + math.AddOneHundred(number));
        }
    }
}
