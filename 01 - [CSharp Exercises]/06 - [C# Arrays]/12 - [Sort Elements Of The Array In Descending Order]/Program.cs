using System;

namespace SortElementsOfTheArrayInDescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 3 elements in the array:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Elements of the array in sorted descending order: " + string.Join(" ", arr));
        }
    }
}
