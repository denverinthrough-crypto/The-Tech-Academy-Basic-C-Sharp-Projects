using System;

namespace DaysApp
{
    // Enum representing the seven days of the week
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Promt the user to type in a day of the week
            Console.WriteLine("Enter the current day of the week: ");
            string input = Console.ReadLine();

            // Try to parse the user's input into the DayOfWeek enum
            try
            {
                // Reject inoput if it's a number
                if (int.TryParse(input, out _))
                    throw new ArgumentException();

                // Enum.Parse converts the string to a DayOfWeek value
                // 'true' makes the comparison case-insensitive
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);

                // If parsing succeeded, display the recognized day
                Console.WriteLine($"Today is: {day}");
            }
            catch (Exception)
            {
                // If the input didn't match any enum value, show a friendly error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
    }
}