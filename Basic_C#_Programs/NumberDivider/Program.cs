
using System;


namespace NumberDivider
{


    // Entry point of the application
    class Program
    {
        static void Main()
        {
            // Instantiate the Divider class
            Divider divider = new Divider();

            // Get a number 
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine()); // read and parse input
            Console.WriteLine();

            // Call DividedByTwo and display result
            divider.DivideByTwo(userNumber);

            // Call method with output parameters and display message
            divider.DivideByTwoOut(userNumber, out int outResult, out string outMessage);
            Console.WriteLine(outMessage);

            // Call overloaded methods
            divider.Divide(userNumber);
            divider.Divide((double)userNumber);

            // Use static class directly without instantiating
            string parity = MathHelper.EvenOrOdd(userNumber);
            Console.WriteLine($"{userNumber} is {parity}");

        }
    }
}