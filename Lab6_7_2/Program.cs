using System;

namespace Lab6_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuildBinomialTheorem(10));
            Console.ReadKey();
        }

        static double Factorial(int n)
        {
            if (n == 0) return 1;

            double result = 1;

            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static double Combination(int m, int n)
        {
            return Factorial(n) / ( Factorial(m) * Factorial(n - m) );
        }

        static string BuildBinomialTheorem(int n)
        {
            string result = "";
            for (int k = 0; k <= n; k++)
            {
                int c = (int)Combination(k, n);
                if (c != 1) result += c;
                if ((n - k) != 0) result += "x^" + (n - k);
                if (k != 0) result += "y^" + k;
                if (k % 2 == 0) result += "-";
                else result += "+";                
            }

            result = result.Remove(result.Length - 1);
            return result;
        }

    }
}
