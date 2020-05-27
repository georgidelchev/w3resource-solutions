using System;

namespace SolutionForty
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine(0);
            }
            else
            {
                int firstValue = Math.Abs(20 - firstNumber);
                int secondValue = Math.Abs(20 - secondNumber);
                if (firstValue < secondValue)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                }
            }
        }
    }
}
