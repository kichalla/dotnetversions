using System;

namespace LibraryA
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
 	    var greeter = new LibraryB.Classd1();
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
