using System;
using System.IO;
using System.Collections.Generic;

namespace SolutionTwentynine
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("C:/Users/gecata/Desktop/Screenshot_2.png");
            Console.WriteLine(fileInfo.Length.ToString() + " bytes");
        }
    }
}
