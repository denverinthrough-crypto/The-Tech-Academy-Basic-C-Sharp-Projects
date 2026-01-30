// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 72;

            //bool isWarm = currentTemperature == roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // ******************************

            // 1. Multiply input by 50

            // Ask the user for a number
            Console.WriteLine("Enter a number to multiply by 50: ");

            // Read the user's input as a string
            string input1 = Console.ReadLine();

            //Convert the string input
            long number1 = Convert.ToInt64(input1);

            // Multiply the number by 50
            long result1 = number1 * 50;

            // Print the result to the console
            Console.WriteLine("Result: " + result1);

            //***************************
            // 2. Add 25 to input

            // Ask user to add number to 25
            Console.WriteLine("\nEnter number to add to 25: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            int result2 = number2 + 25;
            Console.WriteLine("Result: " + result2);

            //*************************
            // 3. Divide input by 12.5

            Console.WriteLine("\nEnter a number to divide by 12.5: ");
            string input3 = Console.ReadLine();
            double number3 = Convert.ToDouble(input3);

            double result3 = number3 / 12.5;
            Console.WriteLine("Result: " + result3);

            //*************************
            // 4. Check if input is greater than 50

            Console.WriteLine("\nEnter a number to check if it is greater than 50: ");
            string input4 = Console.ReadLine();
            int number4 = Convert.ToInt32(input4);

            bool isGreaterThan50 = number4 > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            //*************************
            // 5. Divide input by 7 and show remainder

            Console.WriteLine("\nEnter a number to divide by 7: ");
            string input5 = Console.ReadLine();
            // Convert input to an integer
            int number5 = Convert.ToInt32(input5);
            // Use the modulus operator (%) to get the remaainder
            int remainder = number5 % 7;
            // Print the remainder
            Console.WriteLine("Remainder: " + remainder);

            Console.WriteLine("\nPress any key to exit....");
            Console.ReadKey();












        }
    }
}
