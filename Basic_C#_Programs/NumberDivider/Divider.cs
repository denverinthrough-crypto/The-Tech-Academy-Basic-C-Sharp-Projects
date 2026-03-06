using System;
using System.Collections.Generic;
using System.Text;

namespace NumberDivider
{
    class Divider
    {

        // Divides the given number by 2 and prints the result
        public void DivideByTwo(int number)
        {
            int result = number / 2; // divide by 2
            Console.WriteLine($"{number} divided by 2 = {result}"); // display result
        }

        // Output parameters
        public void DivideByTwoOut(int number, out int result, out string message)
        {
            result = number / 2;
            message = $"{number} / 2 = {result} (via out parameter)"; 
        }

        // Overload: 1
        public void Divide(int number)
        {
            Console.WriteLine($"[Overload - int] {number} / 2 = {number / 2}");
        }

        // Overload: 2
        public void Divide(double number)
        {
            Console.WriteLine($"[Overload - double] {number} /2 = {number / 2}");
        }

    }
}
