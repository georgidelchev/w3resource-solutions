using System;

namespace SolutionFortyfour
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord = string.Empty;
            for (int i = 0; i < word.Length; i += 2)
            {
                newWord += word[i];
            }
            Console.WriteLine(newWord);
        }
    }
}
