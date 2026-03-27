using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class FraudException : Exception // inherit from exception polymorphism
    {
        // method
        public FraudException()  // constructor
            : base() { }
        public FraudException(string message) 
            : base(message) { }
    }
}
