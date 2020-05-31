using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;
            while (number > 1)
            {
                int reminder = number % 2;
                result = reminder.ToString() + result;
                number /= 2;
            }
            
            Console.WriteLine(number.ToString() + result);
        }
    }
}
