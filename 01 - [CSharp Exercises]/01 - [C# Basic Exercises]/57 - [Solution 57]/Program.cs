using System;
using System.Linq;

namespace SolutionFiftyseven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int maxValue = arr[0] * arr[1];
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                maxValue = Math.Max(maxValue, arr[i] * arr[i + 1]);
            }
            Console.WriteLine(maxValue);
        }
    }
}
