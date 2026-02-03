using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && true);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);
            //Console.WriteLine(true == true);

            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);


            // Display the application title
            Console.WriteLine("Car Insurance Application");

            // As for the user's age
            Console.WriteLine("What is your age? ");

            // Read input from the user and convert it to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the user has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");

            // Read input, convert it to lowercase to avoid case issues
            string answer = Console.ReadLine().ToLower();

            // Convert the answer into a boolean value
            // If the user typed "yes", dui becomes true; otherwise false
            bool dui = answer == "yes";

            // Ask how many speeding tickets the user has
            Console.WriteLine("How many speeding tickets do you have? ");

            // Read input and convert it to an integer
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Determine if the user is qualified for insurance
            // Conditions:
            // - Age must be greater than 15
            // - Must NOT have a DUI
            // - Must have 3 or fewer speeding tickets
            bool qualified = (age > 15) && !dui && (tickets <= 3);

            // Display the result
            Console.WriteLine("Qualified for insurance? ");
            Console.WriteLine("You are " + qualified);








            
            















            Console.ReadLine();
        }
    }
}