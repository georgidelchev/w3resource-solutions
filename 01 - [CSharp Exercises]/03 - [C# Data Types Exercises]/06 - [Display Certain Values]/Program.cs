using System;

namespace DisplayCertainValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            for (int i = y; i <= Math.Abs(y); i++)
            {
                int result = (i * i) - (2 * (i)) + 1;
                Console.WriteLine($"({i})^2 - 2*({i}) + 1 = {result}");
            }
        }
    }
}
