using System;

namespace MergeTwoArraysOfSameSizeSortedInAscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the first array: ");
            int firstArraySize = int.Parse(Console.ReadLine());

            int[] firstArray = new int[firstArraySize];
            Console.WriteLine($"Input {firstArraySize} elements in the array:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                firstArray[i] = elements;
            }


            Console.Write("Input the number of elements to be stored in the first array: ");
            int secondArraySize = int.Parse(Console.ReadLine());

            int[] secondArray = new int[secondArraySize];
            Console.WriteLine($"Input {secondArraySize} elements in the array:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                secondArray[i] = elements;
            }

            int[] mergedArrays = new int[firstArray.Length + secondArray.Length];
            Array.Copy(firstArray, mergedArrays, firstArray.Length);
            Array.Copy(secondArray, 0, mergedArrays, firstArray.Length, secondArray.Length);

            Array.Sort(mergedArrays);
            Console.WriteLine("The merged array in ascending order is: ");
            foreach (int values in mergedArrays)
            {
                Console.Write(values + " ");
            }
        }
    }
}
