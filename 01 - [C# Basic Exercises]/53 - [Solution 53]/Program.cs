using System;
using System.Linq;

namespace SolutionFiftythree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool flag = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    flag = true;
                    Console.WriteLine(true);
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine(false);
            }
        }
    }
}
