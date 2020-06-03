using System;

namespace _01_StoreElementsInAnArrayAndPrintIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Console.WriteLine("Elements in the array are: " + string.Join(" ", arr));
        }
    }
}
