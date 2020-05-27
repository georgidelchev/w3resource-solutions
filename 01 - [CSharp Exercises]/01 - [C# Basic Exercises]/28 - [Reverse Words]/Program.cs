using System;

namespace SolutionTwentyeight
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string reversed = string.Empty;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed += words[i] + " ";
            }
            Console.WriteLine(reversed);
        }
    }
}
