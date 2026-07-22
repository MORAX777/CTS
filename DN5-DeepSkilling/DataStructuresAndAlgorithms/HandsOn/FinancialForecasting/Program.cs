using System;

namespace FinancialForecasting
{
    // Aryan Kumar Raj - 231fa18066
    class Program
    {
        // Recursive method to calculate future value
        public static double CalculateFutureValue(double presentValue, double growthRate, int periods)
        {
            // Base case: If there are no more periods, the future value is the present value
            if (periods <= 0)
            {
                return presentValue;
            }

            // Recursive step: Calculate the future value for the next period
            return CalculateFutureValue(presentValue * (1 + growthRate), growthRate, periods - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Student Name: Aryan Kumar Raj");
            Console.WriteLine("Roll No: 231fa18066\n");

            double initialValue = 1000.0;
            double growthRate = 0.05; // 5% growth
            int years = 10;

            double futureValue = CalculateFutureValue(initialValue, growthRate, years);

            Console.WriteLine($"Initial Value: {initialValue:C}");
            Console.WriteLine($"Growth Rate: {growthRate * 100}%");
            Console.WriteLine($"Periods (Years): {years}");
            Console.WriteLine($"Predicted Future Value: {futureValue:C}");
        }
    }
}
