using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1293
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(input[0]),
                A = Convert.ToInt32(input[1]),
                B = Convert.ToInt32(input[2]);
            Console.WriteLine(2*N*A*B);

            Console.ReadLine();
            
        }
    }
}
