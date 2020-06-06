using System;
using System.ComponentModel;

namespace FindSumOfRowsAnColumnsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the square matrix: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input {size} elements in the first matrix:");
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The Matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] rowsSum = new int[size];
            int[] columnsSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    rowsSum[i] += matrix[j, i];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    columnsSum[i] += matrix[i, j];
                }
            }

            Console.WriteLine("The sum or rows and columns of the matrix is: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write($"[{columnsSum[i]}]");
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write($"[{rowsSum[i]}]");
            }
            Console.WriteLine();


        }
    }
}
