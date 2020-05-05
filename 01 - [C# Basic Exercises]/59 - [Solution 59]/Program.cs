using System;
using System.Linq;

namespace SolutionFiftynine
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

            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    counter++;
                }
                if ((arr.Length > i + 2) && (arr[i] >= arr[i + 1]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
