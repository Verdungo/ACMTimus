using System;

namespace _1319
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
                                                                                                            // верхняя строка
                                                                                                            // !!!!!!!!!!!!!!!!!!!!!!!!!!
                                                                                                            // int a = (int)(i * (i - 1) / 2) + 1;
            for (int s = 0; s < size; s++)
            {
                for (int i = size; i > 0; i--)
                {
                    int a = ((i + s) * ((i + s) - 1) / 2) + 1 + s;
                    int d = (i+s > size) ? s+i-size : 0;
                    Console.Write(a-d*d + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
