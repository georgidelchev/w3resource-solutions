using System;
using System.Collections;
using System.Linq;

namespace SeparateOddAndEvenIntegersInSeparateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input {size} elements in the array:");
            int[] arr = new int[size];

            ArrayList evens = new ArrayList();
            ArrayList odds = new ArrayList();
            
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;

                if (arr[i] % 2 == 0)
                {
                    evens.Add(arr[i]);
                }
                else
                {
                    odds.Add(arr[i]);
                }
            }

            Console.Write($"The Even elements are: ");
            foreach (var item in evens)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write($"The Odd elements are: ");
            foreach (var item in odds)
            {
                Console.Write(item + " ");
            }
        }
    }
}
