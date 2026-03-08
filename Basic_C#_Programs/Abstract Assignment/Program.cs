using Abstract_Assignment;
using System;

public class Program
{
    // Main() is where the program startgs executing
    static void Main(string[] args)
    {
        // Prompt the user to enter a first name
        Console.WriteLine("Enter first name: ");

        // Read and store the first name typed by the user
        string firstName = Console.ReadLine();

        // Prompt the user to eneter a last name
        Console.WriteLine("Enter last name: ");

        // Read and store the last name typed by the user
        string lastName = Console.ReadLine();

        // Instantiate a new Employee object using the user's input
        Employee emp = new Employee
        {
            FirstName = firstName, // Assing the entered first name
            LastName = lastName
        };

        // Call SayName() to print the greeting to the console
        emp.SayName();
            
           
    }
}