using System;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"Area: {area:f0}");
            Console.WriteLine($"Perimeter: {perimeter:f0}");
        }
    }
}
