using OOPDemo;
using System;

// The Program class contains the entry point of the application
class Program
{
    // Main method - this is where the program starts executing
    static void Main(string[] args)
    {
        // Prompt the user to enter a first name and read their input
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();

        // Prompt the user to enter a last name and read their input
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        // Instantiate an Employee object and assign the user's input to its property
        Employee emp = new Employee
        {
            FirstName = firstName, // sets the inherited FirstName property user input
            LastName = lastName // sets the inherited LastName property from user input
        };


        // call the SayName() method inherited from the Person superclass.
        // This will print: "Name: Sample Student" to the console.
        emp.SayName();
    }
}