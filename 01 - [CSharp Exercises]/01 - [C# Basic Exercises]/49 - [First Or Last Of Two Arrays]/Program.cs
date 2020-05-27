using System;
using System.Linq;

namespace SolutionFortynine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console
                .ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console
                .ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            if (firstArr.Length >= 1 && secondArr.Length >= 1)
            {
                if ((firstArr[0] == firstArr[firstArr.Length - 1]) ||
                    (secondArr[0] == secondArr[secondArr.Length - 1]))
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
}
