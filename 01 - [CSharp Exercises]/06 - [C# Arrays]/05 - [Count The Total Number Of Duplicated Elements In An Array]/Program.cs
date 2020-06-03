using System;

namespace CountTheTotalNumberOfDuplicateElementsInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is counting total duplicated , for an example you have : 1 1 2 2 3 3 ,
            // 1 is duplicated 1 time , 2 is duplicated 1 time and 3 is duplicated 1 time , 
            // so total duplications are 3!
            
            Console.Write("Input the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine($"Input {size} elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Total number of duplicated elements found in the array is: {counter}");
        }
    }
}
