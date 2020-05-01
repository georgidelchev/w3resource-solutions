using System;

namespace SolutionTwentysix
{
    class Program
    {
        static void Main(string[] args)
        {
            int primesSum = 0;
            int counter = 0;
            int number = 2;

            while (counter < 500)
            {
                if (isNumberPrime(number))
                {
                    primesSum += number;
                    counter++;
                }
                number++;
            }

            Console.WriteLine($"The sum of the first 500 prime numbers is : {primesSum}");
        }
        public static bool isNumberPrime(int number)
        {
            int c = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= c; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
