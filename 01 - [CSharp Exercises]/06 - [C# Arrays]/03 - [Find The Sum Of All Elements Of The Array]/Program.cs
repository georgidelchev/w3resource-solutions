using System;
using System.Linq;

namespace FindTheSumOfAllElementsOfTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }
            int sum = arr.Sum();

            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
        }
    }
}
