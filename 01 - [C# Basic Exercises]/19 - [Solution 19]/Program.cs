using System;

namespace SolutionNineteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            if (firstNumber == secondNumber)
            {
                sum = (firstNumber + secondNumber) * 3;
            }
            else
            {
                sum = firstNumber + secondNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
