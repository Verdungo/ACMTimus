using System;
using System.Linq;

namespace _1567
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string input = "pokupaite gvozdi tolko v kompanii gvozdederov i tovarischi!";
            int cost = 0;

            char[] charString = input.ToCharArray();

            foreach (var simv in charString)
            {
                if ("adgjmpsvy. ".Contains(simv)) cost += 1;
                if ("behknqtwz,".Contains(simv)) cost += 2;
                if ("cfilorux!".Contains(simv)) cost += 3;
            }

            Console.WriteLine(cost.ToString());
        }
    }
}
