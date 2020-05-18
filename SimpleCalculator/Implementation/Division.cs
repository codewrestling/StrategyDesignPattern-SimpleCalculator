using System;
using System.Collections.Generic;
using System.Text;
using SimpleCalculator.Interface;

namespace SimpleCalculator.Implementation
{
    class Division : ICalculator
    {
        public double calculate(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot perform division. Denominator should not be zero." + ex);
                return 0;
            }
        }
    }
}
