using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Assignment
{
    // Interface declaration - defines the Quit() method that implementing classess must provide
    public interface IQuittable
    {
        // Method signature only - no body,no implementation.
        // Any class that implements IQuittable MUST provide its own version of Quit()
        void Quit();

    }
}
