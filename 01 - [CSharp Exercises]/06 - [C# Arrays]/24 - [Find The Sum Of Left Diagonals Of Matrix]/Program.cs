using System;

namespace FindTheSumOfLeftDiagonalsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the square matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            Console.WriteLine("Input elements in the first matrix:");
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

            int sum = 0;
            int counter = size;
            for (int i = 0; i < size; i++)
            {
                counter--;
                for (int j = 0; j < size; j++)
                {
                    if (j == counter)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.Write($"Addition of the left Diagonal elements is: {sum}");
        }
    }
}
