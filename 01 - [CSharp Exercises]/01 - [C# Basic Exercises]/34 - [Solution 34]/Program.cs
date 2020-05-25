using System;

namespace SolutionThirtyfour
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if ((str.Length < 6 && str == "Hello") || (str.StartsWith("Hello") && str[5] == ' '))
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
