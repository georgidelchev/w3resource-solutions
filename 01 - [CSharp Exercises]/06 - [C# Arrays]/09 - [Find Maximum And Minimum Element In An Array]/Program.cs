using System;

namespace FindMaximumAndMinimumElementInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;
            Console.WriteLine($"Input 3 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }

            Console.WriteLine($"Maximum element is: {maxElement}");
            Console.WriteLine($"Minimum element is: {minElement}");
        }
    }
}
