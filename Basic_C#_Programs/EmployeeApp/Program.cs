using System;

namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two employees with different Ids
            Employee emp1 = new Employee { Id = 1, FirstName = "Mark,", LastName = "Johnson" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Dinber", LastName = "Smith" };

            // Create a third employee with the same Id as emp1
            Employee emp3 = new Employee { Id = 1, FirstName = "Mark", LastName = "Johnson" };

            // Compare emp1 and emp2 - different Ids, so == is false and != is true
            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}");
            Console.WriteLine($"emp1 != emp2: {emp1 != emp2}");

            Console.WriteLine();

            // Compare emp1 and emp3 - same Id, so == is true and != is false
            Console.WriteLine($"emp1 == emp3: {emp1 == emp3}");
            Console.WriteLine($"emp1 != emp3: {emp1 != emp3}");

        }

    }
}