using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of 10 employees, at least two name "Joe"
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1,  FirstName = "Joe",    LastName = "Smith"    },
            new Employee { Id = 2,  FirstName = "Jane",   LastName = "Doe"      },
            new Employee { Id = 3,  FirstName = "Joe",    LastName = "Martinez" },
            new Employee { Id = 4,  FirstName = "Alice",  LastName = "Johnson"  },
            new Employee { Id = 5,  FirstName = "Bob",    LastName = "Williams" },
            new Employee { Id = 6,  FirstName = "Carlos", LastName = "Garcia"   },
            new Employee { Id = 7,  FirstName = "Diana",  LastName = "Lee"      },
            new Employee { Id = 8,  FirstName = "Ethan",  LastName = "Brown"    },
            new Employee { Id = 9,  FirstName = "Fiona",  LastName = "Davis"    },
            new Employee { Id = 10, FirstName = "George", LastName = "Wilson"   }
        };

        // foreach loop - filter employees name "Joe" into a new list
        List<Employee> joesForeach = new List<Employee>();
        foreach (Employee employee in employees)
        {
            if (employee.FirstName == "Joe")
                joesForeach.Add(employee);
        }

        Console.WriteLine("*** Joes (foreach) ***");
        foreach (Employee joe in joesForeach)
        
            Console.WriteLine($" Id: {joe.Id} | {joe.FirstName} {joe.LastName}");

        // Lambda - same filter using Where() and a lambda expressions
        List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        Console.WriteLine("\n--- Joes (lambda) ---");
        foreach (Employee joe in joesLambda)
            Console.WriteLine($" Id: {joe.Id} | {joe.FirstName} {joe.LastName}");

        // Lambda - filter employees with Id greater than 5
        List<Employee> highIdEmployees = employees.Where(e => e.Id > 5).ToList();

        Console.WriteLine("\n--- Employees with Id > 5 (lambda) ---");
        foreach (Employee emp in highIdEmployees)
            Console.WriteLine($" Id: {emp.Id} | {emp.FirstName} {emp.LastName}");

           
    }
}