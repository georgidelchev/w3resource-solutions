using System;

namespace SolutionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double adding = firstNumber + secondNumber;
            double subtracting = firstNumber - secondNumber;
            double multiplying = firstNumber * secondNumber;
            double dividing = firstNumber / secondNumber;
            double modulo = firstNumber % secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {adding}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtracting}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplying}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {Math.Round(dividing)}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {modulo}");
        }
    }
}
