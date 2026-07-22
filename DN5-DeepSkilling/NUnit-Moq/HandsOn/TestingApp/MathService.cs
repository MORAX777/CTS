using System;

namespace TestingApp
{
    // Aryan Kumar Raj - 231fa18066
    
    // Interface for dependency to be mocked
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    // Service class to be tested
    public class MathService
    {
        private readonly ICalculator _calculator;

        public MathService(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int CalculateSum(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        public int CalculateDifference(int a, int b)
        {
            return _calculator.Subtract(a, b);
        }
    }
}
