using System;
using System.Linq;

namespace SolutionFiftyfive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to check: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Arr elements: ");
            int[] arr = Console
                .ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();
            int index = 0;
            int product = arr[index] * arr[index + 1];
            index++;
            while (index + 1 < arr.Length)
            {
                product = ((arr[index] * arr[index + 1]) > product) ?
                   (arr[index] * arr[index + 1]) :
                    product;
                index++;
            }
            Console.WriteLine(product == num);
        }
    }
}
