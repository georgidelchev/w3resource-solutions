using System;

namespace TriangleOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = width; i >= 0; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (number.ToString().Length > 1)
                    {
                        Console.Write($"{number} ");
                    }
                    else
                    {
                        Console.Write($"{number}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
