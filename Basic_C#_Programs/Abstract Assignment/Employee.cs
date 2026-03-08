using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    // Employee inherits from Person, gaining FirstName and LastName properties
    // It must implement the abstract SayName() method from the base class.
    public class Employee : Person

    {
        // Override the abstract SayName() method from Person.
        // Prints a greeting using the employee's frist and last name.
        public override void SayName()
        {
            // Display the full name to the console using strign interpolation
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}");
        }
    }
}
