using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1785
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input = Convert.ToInt32(Console.ReadLine());

            if (Input < 5) Console.WriteLine("few");
            else if (Input < 10) Console.WriteLine("several");
            else if (Input < 20) Console.WriteLine("pack");
            else if (Input < 50) Console.WriteLine("lots");
            else if (Input < 100) Console.WriteLine("horde");
            else if (Input < 250) Console.WriteLine("throng");
            else if (Input < 500) Console.WriteLine("swarm");
            else if (Input < 1000) Console.WriteLine("zounds");
            else Console.WriteLine("legion");

            Console.ReadLine();
 
        }
    }
}
