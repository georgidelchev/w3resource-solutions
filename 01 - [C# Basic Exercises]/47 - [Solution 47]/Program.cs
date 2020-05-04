using System;
using System.Linq;

namespace SolutionFortyseven
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

            Console.WriteLine(arr.Sum());
        }
    }
}
