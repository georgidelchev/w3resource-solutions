using System;
using System.Collections;

namespace DeleteAnElementAtDesiredPositionFromAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int size = int.Parse(Console.ReadLine());

            ArrayList aL = new ArrayList(size);

            Console.WriteLine($"Input {size} elements in the array in ascending order:");
            for (int i = 0; i < size; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                aL.Add(elements);
            }

            Console.Write("Input the position where to delete: ");
            int deletingPosition = int.Parse(Console.ReadLine());

            Console.Write($"Old array: ");
            foreach (var item in aL)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            aL.Remove(deletingPosition);

            Console.Write($"New array: ");
            foreach (var item in aL)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
