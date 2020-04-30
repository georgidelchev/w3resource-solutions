using System;

namespace SolutionFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "w3resource";

            Console.WriteLine(removing(word, 1));
            Console.WriteLine(removing(word, 9));
            Console.WriteLine(removing(word, 0));
        }
        public static string removing(string str, int number)
        {
            return str.Remove(number, 1);
        }
    }
}
