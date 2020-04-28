using System;

namespace SolutionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double multiplicationNumbers = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine(multiplicationNumbers);
        }
    }
}
