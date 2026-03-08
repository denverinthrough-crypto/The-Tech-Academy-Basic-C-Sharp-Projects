using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    // Employee inherits from Person, gaining FirstName and LastName properties
    // It must implement the abstract SayName() method from the base class.
    public class Employee : Person

    {
        // Property specific to Employee
        public string JobTitle { get; set; }

        // Override the abstract SayName() method from Person.
        // Prints a greeting using the employee's frist and last name.
        public override void SayName()
        {
            // Display the full name to the console using strign interpolation
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}");
        }

        public override void SayRole()
        {
            // Print the employee's specific job title
            Console.WriteLine($"I am an Employee. My job title is {JobTitle}.");
        }
    }
}
