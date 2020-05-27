using System;

namespace SolutionFiftyfour
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int century = (year / 100);
            if (year % 100 == 0)
            {
                century += 0;
            }
            else
            {
                century += 1;
            }
            Console.WriteLine(century);
        }
    }
}
