using System;
using System.Linq;
using System.Collections;

public class Example
{
    public static int[] sort_numbers(int[] array)
    {

        int[] num = array.Where(a => a != -5).OrderBy(a => a).ToArray();
        int ctr = 0;

        return array.Select(a => a >= 0 ? num[ctr++] : -5).ToArray();
    }

    public static void Main()
    {
        int[] arr = sort_numbers(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
        foreach (int value in arr)
        {
            Console.WriteLine(value.ToString());
        }
    }
}