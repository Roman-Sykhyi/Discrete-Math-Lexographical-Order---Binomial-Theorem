using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        UInt32 highestNumber = 0;
        while (highestNumber == 0)
        {
            Console.Write("Введіть найбільше число множини: ");
            try
            {
                highestNumber = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                highestNumber = 0;
            }
        }

        int n = (int)highestNumber;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        GetAllPermutations(arr, 0, n - 1);

        var result = allPermutationsString
            .Split(' ')
            .Where(x => int.TryParse(x, out _))
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToArray();

        foreach (int item in result)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    public static string allPermutationsString;

    public static void SwapTwoNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public static void GetAllPermutations(int[] list, int k, int m)
    {
        int i;
        if (k == m)
        {
            for (i = 0; i <= m; i++)
            {
                allPermutationsString += list[i];
            }
            allPermutationsString += " ";
        }
        else
            for (i = k; i <= m; i++)
            {
                SwapTwoNumbers(ref list[k], ref list[i]);
                GetAllPermutations(list, k + 1, m);
                SwapTwoNumbers(ref list[k], ref list[i]);
            }
    }
}
