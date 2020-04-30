using System;

namespace SolutionFourteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int deg = int.Parse(Console.ReadLine());
            double degToKelvins = deg + 273;
            double degToFahrenheits = deg * 18 / 10 + 32;

            Console.WriteLine($"Kelvin = {degToKelvins:f0}");
            Console.WriteLine($"Fahrenheit = {degToFahrenheits:f0}");
        }
    }
}
