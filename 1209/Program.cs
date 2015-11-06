using System;
using System.Collections.Generic;

namespace _1209
{
    /*class Program
    {

        static void Main(string[] args)
        {
            ushort lines = ushort.Parse(Console.ReadLine());

            string result = "";

            for (ushort i = 0; i < lines; i++)
            {
               ulong pos = ulong.Parse(Console.ReadLine());

                result += GetXByY(pos) ? "0 " : "1 ";
            }

            Console.WriteLine(result.TrimEnd());
        }

        static bool GetXByY(ulong y)
        {
            double d = ( Math.Sqrt(8 * Convert.ToDouble(y) - 7) - 1)/2;
            return (d - (ulong)d ) != 0;
            //return (1 + Math.Sqrt(8 * Convert.ToDouble(y) - 7)) / 2;
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            List<long> ans = new List<long>();

            long s = System.Int64.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ans.Add(Find(x));
            }

            for (int i = 0; i < s; i++)
            {
                Console.Write(ans[i]);
                Console.Write(" ");
            }
        }

        static long Find(long x)
        {

            // (a)n^2 + (b)n - (c)2x = 0
            // a = 1
            // b = 1
            // c = 2 * x

            double a = 1, b = 1, c = -2 * x + 2;
            double d = b * b - 4 * a * c;
            double p = (-b + Math.Sqrt(d)) / 2 * a;

            return (p - (long)p) > 0 ? 0 : 1;

        }
    }
}
