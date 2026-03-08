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
    }
}
