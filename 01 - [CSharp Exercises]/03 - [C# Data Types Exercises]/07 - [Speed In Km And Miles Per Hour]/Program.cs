using System;

namespace SpeedInKmAndMilesPerHour
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double timeHours = double.Parse(Console.ReadLine());
            double timeMins = double.Parse(Console.ReadLine());
            double timeSecs = double.Parse(Console.ReadLine());

            double secondsTime = (timeHours * 3600) + (timeMins * 60) + timeSecs;
            double mps = distance / secondsTime;
            double kmPerHour = (distance / 1000) / (secondsTime / 3600);
            double milesPerHour = kmPerHour / 1.609;

            Console.WriteLine($"Your speed in meters/sec is {mps:f3}");
            Console.WriteLine($"Your speed in km/h is {kmPerHour:f3}");
            Console.WriteLine($"Your speed in miles/h is {milesPerHour:f3}");
        }
    }
}
