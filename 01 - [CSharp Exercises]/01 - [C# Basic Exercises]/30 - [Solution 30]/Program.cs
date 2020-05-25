using System;
using System.Globalization;

namespace SolutionThirty
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            int decimalNumber = int.Parse(hexadecimalNumber, NumberStyles.HexNumber);
            Console.WriteLine($"From hexadecimalNumber: {hexadecimalNumber}");
            Console.WriteLine($"To decimalNumber: {decimalNumber}");
        }
    }
}
