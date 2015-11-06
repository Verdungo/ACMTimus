using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            string read = Console.ReadLine();
            string[] str = read.Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);

            Console.WriteLine(a + b);
           }
    }
}
