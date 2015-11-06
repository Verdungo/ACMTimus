using System;

namespace _1225
{
    class Program
    {
        static void Main(string[] args)
        {
            int stripes = int.Parse(Console.ReadLine());
            uint[] variants = new uint[stripes+1];

            if (stripes == 1)
            {
                Console.WriteLine(2);
            }
            else
            {
                variants[1] = 2;
                variants[2] = 2;
                uint answer = 2;

                for (int i = 3; i < stripes+1; i++)
                {
                    variants[i] = variants[i - 1] + variants[i - 2];
                    answer = variants[i];
                }
                Console.WriteLine(answer);
            }
        }
    }
}
