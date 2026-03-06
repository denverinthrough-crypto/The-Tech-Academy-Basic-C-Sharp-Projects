using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
     class Person
    {
        // Property to store the person's first name
        public string FirstName { get; set; }

        // Property to store the person's last name
        public string LastName { get; set; }    

        // A void method that prints the person's full name to the console.
        // It takes no parameters and returns nothing
        public void SayName()
        {
            // Concatenates FirstName and LastName and writes the result to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
