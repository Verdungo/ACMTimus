using System;

namespace _1581
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] num = new int[numCount];

            for (int i = 0; i < numCount; i++)
            {
                num[i] = int.Parse(str[i]);
            }

            string result = "";
            int currentCount = 1;
            int prevNum = num[0];
            for (int i = 1; i < numCount; i++)
            {
                if (num[i] == prevNum)
                {
                    currentCount++;
                    continue;
                }
                else
                {
                    result += currentCount.ToString() + " " + num[i - 1].ToString() + " ";
                    currentCount = 1;
                    prevNum = num[i];
                }
            }
            result += currentCount.ToString() + " " + num[numCount-1].ToString() + " ";

            Console.WriteLine(result);

        }
    }
}
