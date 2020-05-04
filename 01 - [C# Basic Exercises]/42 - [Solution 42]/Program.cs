using System;

namespace SolutionThirtytwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord = string.Empty;
            if (word.Length < 4)
            {
                Console.WriteLine(word.ToUpper());
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i >= 0 && i <= 3)
                    {
                        newWord += word[i].ToString().ToLower();
                    }
                    else
                    {
                        newWord += word[i].ToString();
                    }
                }
            }
            Console.WriteLine(newWord);
        }
    }
}
