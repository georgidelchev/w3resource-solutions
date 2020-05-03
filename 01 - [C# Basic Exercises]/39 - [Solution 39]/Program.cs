using System;

namespace SolutionThirtynine
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxValue = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            int minValue = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
    }
}
