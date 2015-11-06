using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1263
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int condidates = int.Parse(str[0]);
            int voters = int.Parse(str[1]);
            int[] count = new int[condidates];

            for (int i = 0; i < voters; i++)
            {
                int vote = int.Parse(Console.ReadLine());

                count[vote-1]++;
            }

            for (int i = 0; i < condidates; i++)
            {
                var percentRes = 100.0 * (double)count[i] / voters;
                Console.WriteLine(string.Format("{0:0.00}%",percentRes));
            }
        }
    }
}
