using System;

namespace InsertNewValueInTheArraySortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array :");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Console.Write("Input the value to be inserted: ");
            int addElement = int.Parse(Console.ReadLine());

            Console.Write("The exist array list is: " + string.Join(" ", arr));
            Console.WriteLine();

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = addElement;

            Array.Sort(arr);

            Console.Write("After Insert the list is: " + string.Join(" ", arr));
        }
    }
}
