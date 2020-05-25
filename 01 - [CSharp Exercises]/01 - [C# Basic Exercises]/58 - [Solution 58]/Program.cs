using System;
using System.Linq;

namespace SolutionFiftyeight
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
            Array.Sort(arr);
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                counter += arr[i + 1] - arr[i] - 1;
            }
            Console.WriteLine(counter);
        }
    }
}
