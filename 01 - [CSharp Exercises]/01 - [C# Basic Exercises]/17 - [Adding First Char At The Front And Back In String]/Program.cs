using System;

namespace SolutionSeventeen
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string newStr = str[0] + str + str[0];
            Console.WriteLine(newStr);
        }
    }
}
