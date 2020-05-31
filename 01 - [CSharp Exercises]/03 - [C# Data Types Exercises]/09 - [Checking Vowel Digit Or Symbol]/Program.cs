using System;

namespace CheckingVowelDigitOrSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("number");
            }
            else
            {
                Console.WriteLine("other symbol");
            }
        }
    }
}
