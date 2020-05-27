using System;
using System.Linq;

namespace SolutionFortyfive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int containsCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    containsCounter++;
                }
            }
            Console.WriteLine($"Number of 5 present in the said array: {containsCounter} times");
        }
    }
}
