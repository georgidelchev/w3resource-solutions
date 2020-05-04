using System;
using System.Linq;

namespace SolutionFifty
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

            int first = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            
            arr[arr.Length - 1] = first;
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
