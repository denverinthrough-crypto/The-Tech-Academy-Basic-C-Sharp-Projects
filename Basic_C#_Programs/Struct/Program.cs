using System;
using System.Globalization;


struct Number
{   
    // Data type is decimal
    public decimal Amount {  get; set; } // property: Amount
}

// The Progrma class the Main() method
class Program
{
    static void Main()
    {
        // Declare a variable to hold the user's input as a string
        string userInput;


        // Declare a variable to hold the successfully parsed decimal value.
        decimal parsedAmount;

        // Loop until the user provides valid input.

        while(true)
        {
            // Prompt the user to enter a number
            Console.WriteLine("Please enter a decimal amount: ");

            // Read the user's input from the console and store it as a string.
            userInput = Console.ReadLine();

            // Validate:
            if(string.IsNullOrWhiteSpace(userInput))
            {
                // Inform the user that empty input is not alowed.
                Console.WriteLine("Input cannot be empty. Please try again.\n");

                // Skip the rest of the loop and prompt again.
                continue;
            }

            // Attempt to parse the string input into a decimal
            if(!decimal.TryParse(userInput, NumberStyles.Any, CultureInfo.InvariantCulture, out parsedAmount))
            {
                // Inform the user that their input was not a valid decimal number
                Console.WriteLine($"'{userInput}' is not valid decimal number. Please try again.\n");

                // Skip te rest of the loop and prompt again.
                continue;
            }

            break;
        }
        // Create an instance of the number struct and assign the validated decimal
        Number myNumber = new Number { Amount = parsedAmount }; ;

        // Print the validated Amount store din myNumber to the console
        Console.WriteLine($"\nThe amount you entered is: {myNumber.Amount}");
    }
}