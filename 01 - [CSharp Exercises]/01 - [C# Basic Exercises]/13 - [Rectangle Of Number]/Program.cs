using System;

namespace SolutionThirteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"{number}{number}{number}");
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{number} {number}");
                }
            }
            Console.WriteLine($"{number}{number}{number}");
        }
    }
}
