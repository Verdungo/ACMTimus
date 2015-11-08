using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1327
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDay = int.Parse(Console.ReadLine());
            int lastDay = int.Parse(Console.ReadLine());

            int fuzes = 0;
            for (int day = firstDay; day <= lastDay; day++)
            {
                if (day%2 == 1) fuzes++;
            }
            Console.WriteLine(fuzes);

        }
    }
}
