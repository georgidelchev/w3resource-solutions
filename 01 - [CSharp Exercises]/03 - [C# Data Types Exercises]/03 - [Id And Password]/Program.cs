using System;

namespace IdAndPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ID: ");
            string userId = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Clear();

            string inputId = string.Empty;
            string inputPassword = string.Empty;

            int wrongAttemptsCount = 0;
            do
            {
                Console.Write("Input ID: ");
                inputId = Console.ReadLine();

                Console.Write("Input Password: ");
                inputPassword = Console.ReadLine();

                wrongAttemptsCount++;
                if (wrongAttemptsCount > 3)
                {
                    Console.WriteLine("Account blocked!");
                    break;
                }
            }
            while ((userId != inputId) || (password != inputPassword));
        }
    }
}
