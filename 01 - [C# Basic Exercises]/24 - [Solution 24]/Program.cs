using System;

namespace SolutionTwentyfour
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);

            string wantedWord = string.Empty;
            int maxChars = int.MinValue;
            foreach (string word in words)
            {
                if (word.Length > maxChars)
                {
                    maxChars = word.Length;
                    wantedWord = word;
                }
            }
            Console.WriteLine($"Longest word: {wantedWord}");
            Console.WriteLine($"{maxChars} symbols");
        }
    }
}
