using System;

namespace SortElementsOfArrayInAscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input 5 elements in the array: ");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Array.Sort(arr);
            Console.Write("Elements of array in sorted ascending order: " + string.Join(" ", arr));
            Console.WriteLine();
        }
    }
}
