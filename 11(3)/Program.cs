using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_
{
    public interface IGraph
    {
        int First();
    }

    public class Point : IGraph
    {
        public int X { get; set; }
        public int Y { get; set; }

     
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        
        public int First()
        {
            return (X > 0 && Y > 0) ? 1 : 0;
        }

        
        public override string ToString()
        {
            return $"Point({X}, {Y})";
        }
    }

    public class Line : IGraph
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        
        public Line(Point p1, Point p2)
        {
            Point1 = p1;
            Point2 = p2;
        }

        
        public int First()
        {
            int count = 0;
            if (Point1.X > 0 && Point1.Y > 0) count++;
            if (Point2.X > 0 && Point2.Y > 0) count++;
            return count;
        }

       
        public override string ToString()
        {
            return $"Line({Point1}, {Point2})";
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = new Point(2, 3);  // Первая четверть
            Point p2 = new Point(-1, -1); 

           
            Line line = new Line(p1, p2);

            
            Console.WriteLine("Количество точек в первой четверти на линии: " + line.First());
        }
    }
}       
