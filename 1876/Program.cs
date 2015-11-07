using System;

namespace _1876
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int left = Convert.ToInt32(input[0]);
            int right = Convert.ToInt32(input[1]);

            int time = 3 * 39;
            right -= 39;
            left -= 39;

            int v1 = right * 2 + 1;
            int v2 = left * 2;

            //Console.WriteLine(time + v1);
            //Console.WriteLine(time + v2);

            time += v1 >= v2 ? v1 : v2;
            /*if (right >= left)
            {
                time += right * 2 + 1;
            }
            else
            {
                time += left * 2;
            }
            */
            
            Console.WriteLine(time);
            //Console.ReadLine();
        }
    }
}
