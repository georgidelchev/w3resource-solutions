using System;

namespace InsertNewValueInTheArrayUnsortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array in ascending order:");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Console.Write("Input the value to be inserted: ");
            int insertValue = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input the Position, where the value to be inserted: ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("The current list of the array: " + string.Join(" ", arr));

            Array.Resize(ref arr, arr.Length + 1);

            for (int i = arr.Length - 1; i >= position; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[position] = insertValue;

            Console.WriteLine();
            Console.WriteLine("After Insert the element the new list is: " + string.Join(" ", arr));
        }
    }
}
