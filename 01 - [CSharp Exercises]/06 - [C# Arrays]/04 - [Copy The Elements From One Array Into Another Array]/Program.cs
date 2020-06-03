using System;

namespace CopyTheElementsFromOneArrayIntoAnotherArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            int[] secondArr = new int[arr.Length];
            Array.Copy(arr, secondArr, arr.Length);

            Console.WriteLine();
            Console.Write("The elements stored in the first array are: ");
            foreach (int values in arr)
            {
                Console.Write(values + " ");
            }

            Console.WriteLine();
            Console.Write("The elements copied into the second array are: ");
            foreach (int values in secondArr)
            {
                Console.Write(values + " ");
            }
            Console.WriteLine();
        }
    }
}
