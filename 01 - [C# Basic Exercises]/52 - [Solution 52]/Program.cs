using System;
using System.Linq;

namespace SolutionFiftytwo
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
            int[] thirdArr = Console
                .ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int[] newArr = new int[3];


            if ((firstArr.Length < 2) && (secondArr.Length < 2) && (thirdArr.Length < 2))
            {
                Console.WriteLine("No middle element");
            }
            else
            {
                int firstArrMiddle = firstArr.Length / 2;
                int secondArrMiddle = firstArr.Length / 2;
                int thirdArrMiddle = firstArr.Length / 2;

                newArr[0] += firstArr[firstArrMiddle];
                newArr[1] += secondArr[secondArrMiddle];
                newArr[2] += thirdArr[thirdArrMiddle];
            }

            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
