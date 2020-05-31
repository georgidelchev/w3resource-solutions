using System;

namespace SurfaceAndVolumeOfTheSphere
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double surface = 4 * Math.PI * Math.Pow(rad, 2);
            double volume = 4d / 3d * Math.PI * Math.Pow(rad, 3);

            Console.WriteLine($"Surface: {surface:f5}");
            Console.WriteLine($"Volume: {volume:f5}");
        }
    }
}
