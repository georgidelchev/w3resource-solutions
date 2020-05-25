using System;
using System.Linq;

namespace SolutionFortysix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = Console.
                ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if (arr[0] == number || arr[arr.Length - 1] == number)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
