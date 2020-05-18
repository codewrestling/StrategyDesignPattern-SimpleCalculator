using System;
using SimpleCalculator.Implementation;
using SimpleCalculator.Interface;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 2;
            double num2 = 3;
            Context myCalculator = new Context(new Addition());
            double result = myCalculator.execute(num1, num2);
            Console.WriteLine("Result is " + result);
        }
    }
}
