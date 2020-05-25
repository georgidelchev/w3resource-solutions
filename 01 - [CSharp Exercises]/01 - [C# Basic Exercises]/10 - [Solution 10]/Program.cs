using System;

namespace SolutionTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int result = (x + y) * z;
            int secondResult = (x * y) + (y * z);
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z} is" +
                $" {result} and x.y + y.z is {secondResult}");
        }
    }
}
