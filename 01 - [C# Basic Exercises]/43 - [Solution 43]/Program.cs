using System;

namespace SolutionFortythree
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word[0] == 'w' && word[1] == 'w' && word[2] == 'w')
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
