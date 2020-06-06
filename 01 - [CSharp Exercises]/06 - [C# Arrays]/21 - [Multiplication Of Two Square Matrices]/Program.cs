using System;

namespace MultiplicationOfTwoSquareMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the rows of first matrix: ");
            int firstMatrixRows = int.Parse(Console.ReadLine());
            Console.Write("Input the columns of first matrix: ");
            int firstMatrixColumns = int.Parse(Console.ReadLine());

            Console.Write("Input the rows second matrix: ");
            int secondMatrixRows = int.Parse(Console.ReadLine());
            Console.Write("Input the columns second matrix: ");
            int secondMatrixColumns = int.Parse(Console.ReadLine());

            Console.WriteLine();

            while ((firstMatrixRows != secondMatrixRows) ||
                (firstMatrixColumns != secondMatrixColumns) ||
                (firstMatrixRows != firstMatrixColumns) ||
                (secondMatrixRows != secondMatrixColumns))
            {
                Console.WriteLine("Please enter a valid rows and columns!!");

                Console.Write("Input the rows of first matrix: ");
                firstMatrixRows = int.Parse(Console.ReadLine());
                Console.Write("Input the columns of first matrix: ");
                firstMatrixColumns = int.Parse(Console.ReadLine());

                Console.Write("Input the rows second matrix: ");
                secondMatrixRows = int.Parse(Console.ReadLine());
                Console.Write("Input the columns second matrix: ");
                secondMatrixColumns = int.Parse(Console.ReadLine());
            }

            int[,] firstMatrix = new int[firstMatrixRows, firstMatrixColumns];
            int[,] secondMatrix = new int[secondMatrixRows, secondMatrixColumns];

            Console.Clear();

            Console.WriteLine("Input elements in the first matrix:");
            for (int i = 0; i < firstMatrixRows; i++)
            {
                for (int j = 0; j < firstMatrixRows; j++)
                {
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix:");
            for (int i = 0; i < secondMatrixRows; i++)
            {
                for (int j = 0; j < secondMatrixRows; j++)
                {
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The First Matrix is:");
            for (int i = 0; i < firstMatrixRows; i++)
            {
                for (int j = 0; j < firstMatrixRows; j++)
                {
                    Console.Write(firstMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Second Matrix is:");
            for (int i = 0; i < secondMatrixRows; i++)
            {
                for (int j = 0; j < secondMatrixRows; j++)
                {
                    Console.Write(secondMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The multiplication of two matrix is:");
            int[,] multiplicationMatrix = new int[firstMatrixRows, secondMatrixRows];
            for (int i = 0; i < firstMatrixRows; i++)
            {
                for (int j = 0; j < firstMatrixRows; j++)
                {
                    multiplicationMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
                }
            }

            for (int i = 0; i < firstMatrixRows; i++)
            {
                for (int j = 0; j < firstMatrixRows; j++)
                {
                    Console.WriteLine(multiplicationMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
