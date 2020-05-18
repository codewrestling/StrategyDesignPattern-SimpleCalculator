using SimpleCalculator.Interface;

namespace SimpleCalculator
{
    class Context
    {
        private ICalculator calculator;

        public Context(ICalculator operation)
        {
            calculator = operation;
        }

        public double execute(double num1, double num2)
        {
            return calculator.calculate(num1, num2);
        }

    }
}
