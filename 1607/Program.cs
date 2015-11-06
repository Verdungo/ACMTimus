using System;

namespace _1607
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int P = int.Parse(input[0]);
            int dP = int.Parse(input[1]);
            int T = int.Parse(input[2]);
            int dT = int.Parse(input[3]);

            int finalPrice = P;

            if (T > P)
            {
                finalPrice = T;
                while (true)
                {
                    if (finalPrice > P + dP)
                    {
                        P += dP;
                        finalPrice = P;
                    }
                    else
                    {
                        break;
                    }

                    if (finalPrice < T - dT)
                    {
                        T -= dT;
                        finalPrice = T;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(finalPrice);
        }
    }
}
