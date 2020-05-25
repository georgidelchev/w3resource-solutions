using System;
using System.Linq;

namespace SolutionThirtyseven
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "PHP Tutorials";

            if (str.Substring(1, 2) == "HP")
            {
                str = str.Remove(1, 2);
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
