using System;

class Program
{
    static void Main()
    {
        // Print the title of the program
        Console.WriteLine("Anonymous Income Comparison Program");

        // ---- Person 1 ----
        // Print label for Person 1
        Console.WriteLine("\nPerson 1");

        // Ask for Person 1's hourly rate
        Console.Write("Hourly Rate: ");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

        // Ask for Person 1's hours worked per week
        Console.Write("Hours worked per week: ");
        double hoursPerWeek1 = Convert.ToDouble(Console.ReadLine());

        // ---- Person 2 ----
        // Print label for Person 2
        Console.WriteLine("\nPerson 2");

        // Ask for Person 2's hourly rate
        Console.Write("Hourly Rate: ");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

        // Ask for Person 2's hours worked per week
        Console.Write("Hours worked per week: ");
        double hoursPerWeek2 = Convert.ToDouble(Console.ReadLine());

        // Calculate annual salary for Person 1
        // 52 weeks in a year
        double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;

        // Calculate annual salary for Person 2
        double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

        // Display Person 1's annual salary
        Console.WriteLine("\nAnnual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        // Display Person 2's annual salary
        Console.WriteLine("\nAnnual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        // Compare salaries and store the result (true or false)
        bool person1MakesMore = annualSalary1 > annualSalary2;

        // Display the comparison result
        Console.WriteLine("\nPerson 1 makes more money than Person 2");
        Console.WriteLine(person1MakesMore);
    }
}
