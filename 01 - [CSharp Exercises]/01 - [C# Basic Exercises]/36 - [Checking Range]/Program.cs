using System;

namespace SolutionThirtysix
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if ((firstNumber >= -10 && firstNumber <= 10) && (secondNumber >= -10 && secondNumber <= 10))
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
