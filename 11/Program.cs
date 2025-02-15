using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) { X = x; Y = y; }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p1.X, p1.Y - p2.Y);
        }
        public int CompareTo(Point other)
        {
            if (other == null) return 1;
            double distance1 = Math.Sqrt(X * X + Y * Y);
            double distance2 = Math.Sqrt(other.X * other.X + other.Y * other.Y);
            if (distance1 > distance2) return 1;
            if (distance1 < distance2) return -1;
            return 0;
        }
        public override string ToString()
        {
            return X + " " + Y;
        }










        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите первую строку:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2 строку:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sum = num1 + num2;
                string result = sum.ToString();
                Console.WriteLine(result);


                string[,] array =
                {
                {"Hello","Josh" },
                {"Hello","Stella" },
                {"Hello","Kate"}
            };
                int letterCount = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        letterCount += array[i, j].Length;
                    }
                }
                Console.WriteLine(letterCount);
                Point p1 = new Point(3, 2);
                Point p2 = new Point(2, 2);
                Point p3 = p1 + p2;
                Point p4 = p1 - p2;
                Console.WriteLine("Сложение" + p3);
                Console.WriteLine("Вычитание" + p4);
                int comparison = p1.CompareTo(p2);
                if (comparison < 0)
                {
                    Console.WriteLine("Ближе чем 2");
                }
                else if (comparison > 0)
                {
                    Console.WriteLine("Дальше чем 2");
                }
                else { Console.WriteLine("На одном расстоянии"); }

            }
        }
    }
}

