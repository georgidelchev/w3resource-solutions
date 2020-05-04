using System;

namespace SolutionFortyone
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int containsCounter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'w')
                {
                    containsCounter++;
                }
            }

            if (containsCounter >= 1 && containsCounter <= 3)
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
