using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 10, 25, 50, 100, 200};

        // Display the list so the user knows what they're dividing
        Console.WriteLine("===Division Console App===");
        Console.WriteLine("List of integers: " + string.Join(", ", numbers));
        Console.WriteLine();

        // Prompt the user to enter a divisor
        Console.Write("Enter a number to divide each item by: ");
        string userInput = Console.ReadLine();

        // This handles both DivideByZeroException and FormateException
        try
        {
            int divisor = int.Parse(userInput);

            Console.WriteLine();

            Console.WriteLine("Result: ");

            // Loop through each integer in the list and divide it by the user's divisor
            foreach(int number in numbers)
            {
                int result = number / divisor;

                Console.WriteLine($" {number} / {divisor} = {result}");

            }
        }
        catch (DataMisalignedException ex)
        {
            Console.WriteLine();
            Console.WriteLine("[ERROR] Cannot divide by zero.");
            Console.WriteLine($" Details: {ex.Message}");

        }
        Console.WriteLine();
        Console.WriteLine("Program has emerged from the try/catch block and continues executing.");
        Console.WriteLine("Press any key to exit....");
        Console.ReadKey();






        //try
        //{
        //    Console.WriteLine("Pick a number: ");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number: ");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();

        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number!");
        //    return;
        //}
        //catch(DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero!");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine(); 
        //}
       
       
        
    }
}