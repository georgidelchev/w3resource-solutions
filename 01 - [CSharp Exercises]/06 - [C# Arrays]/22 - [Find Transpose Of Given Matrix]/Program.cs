using System;

namespace FindTransposeOfGivenMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Input the columns of the matrix: ");
            int columns = int.Parse(Console.ReadLine());

            while (rows != columns)
            {
                Console.WriteLine("Please enter valid rows and columns!!");

                Console.Write("Input the rows of the matrix: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Input the columns of the matrix: ");
                columns = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Input elements in the matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] transposedMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    transposedMatrix[i, j] = matrix[j, i];
                }
            }

            Console.WriteLine("The Transpose of a matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
