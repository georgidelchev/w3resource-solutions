using System;

namespace SolutionTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(Math.Abs((firstNumber - secondNumber) * 2));
            }
            else
            {
                Console.WriteLine(Math.Abs(firstNumber - secondNumber));
            }
        }
    }
}
