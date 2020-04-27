using System;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
        }
    }
}
