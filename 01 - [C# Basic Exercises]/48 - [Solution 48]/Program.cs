using System;
using System.Linq;

namespace SolutionFortyeight
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

            if (arr.Length >= 1)
            {
                if (arr[0] == arr[arr.Length - 1])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
