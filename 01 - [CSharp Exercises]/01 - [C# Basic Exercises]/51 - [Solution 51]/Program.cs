using System;
using System.Linq;

namespace SolutionFiftyone
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

            if (arr[0] > arr[arr.Length - 1])
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                Console.WriteLine($"Highest value between first and last values of the said array: {arr[arr.Length - 1]}");
            }
        }
    }
}
