using System;

namespace _2001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            int aWithBerries = int.Parse(str1[0]);
            int bWithBerries = int.Parse(str1[1]);

            string[] str2 = Console.ReadLine().Split(' ');
            int bWithoutBerries = int.Parse(str2[1]);

            string[] str3 = Console.ReadLine().Split(' ');
            int aWithoutBerries = int.Parse(str3[0]);

            Console.WriteLine(String.Format("{0} {1}", aWithBerries-aWithoutBerries, bWithBerries - bWithoutBerries));
        }
    }
}
