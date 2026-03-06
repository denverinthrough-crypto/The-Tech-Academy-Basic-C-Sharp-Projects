using System;

// Class that holds math method
class MathDisplay
{
    // Squares the first integer, displays the second
    public void ProcessNumbers(int operand, int display)
    {
        Console.WriteLine($"{operand} squared = {operand * operand}"); // math operation
        Console.WriteLine($"Display value: {display}"); // print second integer
    }
        
}

class Program

{
    static void Main()
    {
        MathDisplay mathObj = new MathDisplay(); // create instance of MathDisplay

        // Get two integers from the user
        Console.WriteLine("Enter first integer (will be squared): ");
        int operand = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second integer (will be displayed): ");
        int display = int.Parse(Console.ReadLine());

        Console.WriteLine();

            
        // Call method with positional arguments
        mathObj.ProcessNumbers(operand, display);

        // Call method with named arguments
        mathObj.ProcessNumbers(operand: operand, display: display);
    }
}

