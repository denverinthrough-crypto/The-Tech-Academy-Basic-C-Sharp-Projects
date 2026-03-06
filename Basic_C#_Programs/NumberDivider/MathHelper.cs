using System;
using System.Collections.Generic;
using System.Text;

namespace NumberDivider
{
     static class MathHelper
    {
        // Returns whether a number is even or odd
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "even" : "odd"; // check remainder
        }
    }
}
