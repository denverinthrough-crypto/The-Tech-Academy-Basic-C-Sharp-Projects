using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    public class Employee
    {
        // Properties to store employee data
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // "==" checks if two employees have the same Id
        public static bool operator ==(Employee a, Employee b) => a.Id == b.Id;

        // "!=" must be overloaded when "==" is - it returns the opposite result
        public static bool operator !=(Employee a, Employee b) => a.Id != b.Id;

        // Required overrides to keepequality consistent
        public override bool Equals(object? obj) => obj is Employee e && Id == e.Id;
        public override int GetHashCode() => Id.GetHashCode();
        
        
        
    }
}
