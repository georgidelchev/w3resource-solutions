using System;

namespace SolutionTwentyseven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string converted = number.ToString();

            int sum = 0;
            for (int i = 0; i < converted.Length; i++)
            {
                int digit = int.Parse(converted[i].ToString());
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
