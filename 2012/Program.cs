using System;

namespace _2012
{
    class Program
    {
        static void Main(string[] args)
        {
            int problemCount = 12;
            double hours = 5;

            int f = Convert.ToInt16(Console.ReadLine());

            string result = 0.75 * (problemCount - f) <= (hours - 1) ? "YES" : "NO";

            Console.WriteLine(result);
        }
    }
}
