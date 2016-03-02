using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new LibraryA.Calculator();
            var sum = calculator.Add(10, 20);
            var greeter = new LibraryB.Class1();

            Console.WriteLine($"{sum}, {greeter.Greeting()}");
        }
    }
}
