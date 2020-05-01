using System;

namespace SolutionTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            if ((firstNumber == 20 || secondNumber == 20) || (sum == 20))
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
