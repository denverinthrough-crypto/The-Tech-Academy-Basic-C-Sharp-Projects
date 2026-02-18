using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcom message (must be first line)
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below");

            // Declare variables for weight and dimensions
            double weight; // Stores package weight
            double width; // Stores package width
            double height; // Stores package height
            double length; // Stores package length;

            // Ask user  for package weight
            Console.WriteLine("Please enter the package weigth: ");
            weight = Convert.ToDouble(Console.ReadLine()); // Conver text input to number

            // If weight is too heavy, show error and stop program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program
            }

            // As user for width
            Console.WriteLine("Please enter the package width: ");
            width = Convert.ToDouble(Console.ReadLine());

            // Ask user for height
            Console.WriteLine("Please enter the package height: ");
            height = Convert.ToDouble(Console.ReadLine());

            // Ask user for length
            Console.WriteLine("Please enter the package length; ");
            length = Convert.ToDouble(Console.ReadLine());

            // Check if total dimesnions exceed 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. ");
                return; // Ends program
            }

            // Multiply dimensions together to get volume
            double volume = width * height * height;

            // Multiply volume by weight
            double cost = volume * weight;

            // Divide by 100 to get final shipping quote
            double quote = cost / 100;

            // Display quote formatted as currency (two decimal places)
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Final messasge
            Console.WriteLine("Thank you!");


            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 24 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            //Console.WriteLine(result);
            //Console.ReadLine();
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");

            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("UHHHH......something went wrong.");
            //}

            //Console.ReadLine();



                //int currentTemperature = 80;
                //int roomTemperature = 70;

                //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

                //Console.WriteLine(comparisonResult);
                //Console.ReadLine();


                //if (currentTemperature == roomTemperature)
                //{
                //    Console.WriteLine("It is exactly room temperature.");
                //}
                //else if (currentTemperature > roomTemperature)
                //{
                //    Console.WriteLine("It is warmer than room temperature.");
                //}
                //else if (roomTemperature > currentTemperature)
                //{
                //    Console.WriteLine("Room temperature is warmer than current temperature.");
                //}
                //else
                //{
                //    Console.WriteLine("It is not exactly room temperature.");

                //}
                Console.ReadLine();
        }
    }
}