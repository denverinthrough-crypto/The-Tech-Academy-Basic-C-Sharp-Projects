using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    public abstract class Person
    {
        // Property to store the person's first name
        public string FirstName { get; set; }

        // Property to store the person's last name
        public string LastName { get; set; }

        // Abstract method - no obdy here, subclasses MUST implement this
        public abstract void SayName();

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello! I am {FirstName} {LastName}"); ;


        }

        public virtual void SayRole()
        {
            // Default role message = Employee will override this
            Console.WriteLine("I am a person.");
        }

        
    }
}
