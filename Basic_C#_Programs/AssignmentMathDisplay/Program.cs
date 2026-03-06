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

        // Call method with positional arguments
        mathObj.ProcessNumbers(5, 42);

        // Call method with named arguments
        mathObj.ProcessNumbers(operand: 7, display: 42);
    }
}

