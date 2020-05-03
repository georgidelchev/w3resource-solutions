using System;
using System.Linq;

namespace SolutionThirtyone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.
                ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.
                ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                int sum = 0;
                sum = firstArray[i] * secondArray[i];
                Console.Write($"{sum} ");
            }
        }
    }
}
