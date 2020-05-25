using System;

namespace SolutionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());

            double dividing = firstNumber / secondNumber;
            Console.WriteLine(dividing);
        }
    }
}
