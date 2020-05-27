using System;

namespace SolutionTwentyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if ((Math.Abs(number - 100) <= 20) || (Math.Abs(number - 200) <= 20))
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
