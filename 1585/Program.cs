using System;
using System.Collections.Generic;
using System.Linq;


namespace _1585
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> P = new Dictionary<string, int>()
            {
                { "Emperor Penguin", 0 },
                { "Little Penguin", 0 },
                { "Macaroni Penguin", 0 }
            };
            int penguins = int.Parse(Console.ReadLine());
            for (int i = 0; i < penguins; i++)
            {
                P[Console.ReadLine()]++;
            }

            Console.WriteLine(P.Where(o=>o.Value == P.Values.Max()).First().Key);
        }
    }
}
