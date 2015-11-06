using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int letters = Convert.ToInt32(Console.ReadLine());

            string[] recepient = new string[letters];
            for (int i = 0; i < letters; i++)
            {
                recepient[i] = Console.ReadLine();
            }

            int steps = 0;
            int currentPos = 1;
            for (int j = 0; j < letters; j++)
            {
                int cabinet = GetCabinet(recepient[j]);
                steps += Math.Abs(cabinet - currentPos);
                currentPos = cabinet;
            }

            if (letters == 1) steps = GetCabinet(recepient[0]) - 1;

            Console.WriteLine(steps.ToString());
        }

        private static int GetCabinet(string name)
        {
            switch (name.ToCharArray()[0])
            {
                case 'A':
                case 'P':
                case 'O':
                case 'R':
                    return 1;
                case 'B':
                case 'M':
                case 'S':
                    return 2;
                case 'D':
                case 'G':
                case 'J':
                case 'K':
                case 'T':
                case 'W':
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
