using System;

namespace PrintAllUniqueElementsInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input {size} elements in the array:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Console.WriteLine("The unique elements found in the array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
