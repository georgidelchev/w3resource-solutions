using System;

namespace FindTheSecondLargestElementInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array:");
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
                if (arr[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if (arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }
            Console.WriteLine($"The Second largest element in the array is: {secondMax}");
        }
    }
}
