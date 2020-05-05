using System;
public class Example
{
    public static void Main()
    {
        Console.WriteLine(sumMatrix(
                    new int[][] {
                    new int[]{0, 2, 3, 2},
                    new int[]{0, 6, 0, 1},
                    new int[]{4, 0, 3, 0}
                                            }));
        Console.WriteLine(sumMatrix(
                    new int[][] {
                    new int[]{1, 2, 1, 0 },
                    new int[]{0, 5, 0, 0},
                    new int[]{1, 1, 3, 10 }
                                            }));
        Console.WriteLine(sumMatrix(
                    new int[][] {
                    new int[]{1, 1},
                    new int[]{2, 2},
                    new int[]{3, 3},
                    new int[]{4, 4}
                                            }));
    }
    public static int sumMatrix(int[][] matrix)
    {
        int counter = 0;
        for (int i = 0; i < matrix[0].Length; i++)
            for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                counter += matrix[j][i];

        return counter;
    }
}