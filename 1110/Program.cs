using System;

namespace _1110
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            UInt64 N = UInt64.Parse(input[0]);
            UInt64 M = UInt64.Parse(input[1]);
            UInt64 Y = UInt64.Parse(input[2]);

            string result = "";

            for (UInt64 i = 0; i < M-1; i++)
            {
                if (Math.Pow((double)i,(double)N) % M == Y)
                {
                    result += i.ToString() + " ";
                }
            }

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("-1");
            }

            Console.ReadLine();

        }
    }
}
