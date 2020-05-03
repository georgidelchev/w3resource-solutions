using System;


namespace SolutionThirtytwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] splitted = word.Split(new[] { " " }, StringSplitOptions.None);

            if (splitted.Length < 4)
            {
                foreach (var item in splitted)
                {
                    Console.Write($"{item} ");
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(string.Join(".", splitted[splitted.Length - 1]));
                }
            }
        }
    }
}