using SimpleCalculator.Interface;

namespace SimpleCalculator.Implementation
{
    class Addition : ICalculator
    {
        public double calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
