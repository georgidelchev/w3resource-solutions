using System;

namespace FindTheSecondSmallestElementInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array:");

            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
                if (arr[i] < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = arr[i];
                }
                else if (arr[i] < secondMin)
                {
                    secondMin = arr[i];
                }
            }

            Console.WriteLine($"The Second smallest element in the array is: {secondMin}");
        }
    }
}
