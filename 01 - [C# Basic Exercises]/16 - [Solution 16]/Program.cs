using System;

namespace SolutionSixteen
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(Changing(word));
        }
        public static string Changing(string str)
        {
            int length = str.Length;
            return str[length - 1] + str.Substring(1, length - 2) + str[0];
        }
    }
}
