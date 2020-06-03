using System;

namespace CountTheFrequencyOfEachElementOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input 3 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Console.Write($"Frequency of all elements of array:");
            Console.WriteLine();
            int[] elementsFrequency = new int[arr.Length];
            int visitedElements = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int currCounter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currCounter++;
                        elementsFrequency[j] = visitedElements;
                    }
                }
                if (elementsFrequency[i] != visitedElements)
                {
                    elementsFrequency[i] = currCounter;
                }
            }

            for (int i = 0; i < elementsFrequency.Length; i++)
            {
                if (elementsFrequency[i] != visitedElements)
                {
                    Console.WriteLine($"{arr[i]} occurs {elementsFrequency[i]} times");
                }
            }
        }
    }
}
