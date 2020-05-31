using System;

namespace OperationsWithTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = 0;
            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == '*' || operation == 'x')
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == '/')
            {
                result = firstNumber / secondNumber;
            }
            else if (operation == '%')
            {
                result = firstNumber % secondNumber;
            }

            Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
        }
    }
}
