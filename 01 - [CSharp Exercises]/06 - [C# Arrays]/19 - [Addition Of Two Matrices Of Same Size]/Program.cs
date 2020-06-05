using System;

namespace AdditionOfTwoMatricesOfSameSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the square matrix: ");
            int size = int.Parse(Console.ReadLine());

            int[,] firstMatrix = new int[size, size];
            Console.WriteLine("Input elements in the first matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] secondMatrix = new int[size, size];
            Console.WriteLine("Input elements in the first matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The First matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(firstMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Second matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(secondMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] additionalMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    additionalMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            Console.WriteLine("The Addition of two matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(additionalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
