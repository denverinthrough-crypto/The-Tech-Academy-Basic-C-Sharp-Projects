// See https://aka.ms/new-console-template for more information
using System;

namespace StudentReport
{
    class Program
    {

        static void Main(string[] args)
        {
            // Dispaly the school name and report title
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            // Ask for the student's name and store the input
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            // Ask for the course name
            Console.WriteLine("What course are you on? ");
            string course = Console.ReadLine();

            // Ask for the page number and convert input to an integer
            Console.WriteLine("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help (true or false)
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);

            // Ask for positive feedback or experiences
            Console.WriteLine("Is there any positive experiences you'd like to share? ");
            string feedback = Console.ReadLine();

            // As for number of study hours and convert to int
            Console.WriteLine("How many hours did you study today? ");
            int studyHours = Convert.ToInt32(Console.ReadLine());

            // Display a closing message
            Console.WriteLine("\nThank you for you answers. ");
            Console.WriteLine("An instructor will respond shortly. ");
            Console.WriteLine("Have a great day! ");

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();

        


        }
    }
}
