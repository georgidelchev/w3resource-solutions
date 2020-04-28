using System;

namespace SolutionNine
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber + forthNumber;
            int average = sum / 4;
            Console.WriteLine($"The average of " +
                $"{firstNumber} , {secondNumber} , {thirdNumber} , {forthNumber}" +
                $" is: {average}");
        }
    }
}
