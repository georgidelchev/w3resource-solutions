using System;

namespace SolutionTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{number} ");
                    }
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{number}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
