using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1881
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            int rowsOnPage = int.Parse(str1[0]);
            int symbolsInRow = int.Parse(str1[1]);
            int wordsInText = int.Parse(str1[2]);

            int pages = 1;
            int currentRow = 1;
            int currentSymbols = 0;
            for (int i = 0; i < wordsInText; i++)
            {
                string word = Console.ReadLine();

                if (currentSymbols + word.Length > symbolsInRow)
                {
                    if (currentRow + 1 > rowsOnPage)
                    {
                        pages++;
                        currentRow = 1;
                    }
                    else
                    {
                        currentRow++;
                    }
                    currentSymbols = word.Length + 1;
                }
                else
                {
                    currentSymbols += word.Length + 1;
                }
            }

            Console.WriteLine(pages);
        }
    }
}
