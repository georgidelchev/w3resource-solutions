using System;

namespace SolutionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int multiplying = number * i;
                Console.WriteLine($"{number} * {i} = {multiplying}");
            }
        }
    }
}
