using System;
using System.Linq;

namespace ReadNumbersOfValuesInAnArrayAndDisplayItInReverseOrder
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

            Console.Write("Before reverse: ");
            foreach (int values in arr)
            {
                Console.Write(values + " ");
            }

            Array.Reverse(arr);

            Console.Write("After reverse: ");
            foreach (int values in arr)
            {
                Console.Write(values + " ");
            }
        }
    }
}
