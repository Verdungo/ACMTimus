using System;
using System.Collections.Generic;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int vertexes = int.Parse(input[0]);
            double radius = double.Parse(input[1]);

            double lenght = 2 * Math.PI * radius;
            List<Point> points = new List<Point>();
            for (int i = 0; i < vertexes; i++)
            {
                points.Add(new Point(Console.ReadLine()));
            }

            for (int i = 1; i < vertexes; i++)
            {
                lenght += GetDistance(points[i], points[i - 1]);
            }

            lenght += GetDistance(points[0], points[vertexes - 1]);

            Console.WriteLine("{0:0.00}",lenght);
        }

        private static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

        class Point
        {
            public double X;
            public double Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public Point(string str)
            {
                string[] s = str.Split(' ');
                
                X = Convert.ToDouble(s[0]);
                Y = Convert.ToDouble(s[1]);
            }
        }
    }
}
