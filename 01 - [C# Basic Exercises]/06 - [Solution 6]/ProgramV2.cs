using System;
using System.Linq;

namespace SolutionSixV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // using array and linq
            
            double[] numbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double multiplication = 1;
            foreach (var values in numbers)
            {
                multiplication *= values;
            }
            
            Console.WriteLine(multiplication);
        }
    }
}
