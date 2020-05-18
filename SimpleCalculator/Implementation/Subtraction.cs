using System;
using System.Collections.Generic;
using System.Text;
using SimpleCalculator.Interface;

namespace SimpleCalculator.Implementation
{
    class Subtraction : ICalculator
    {
        public double calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
