using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1
{
    class CircleFinder
    {
        public class Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
        }

        public class CircleResult
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
            public int PointsCount { get; set; }
        }

        public CircleResult FindCircleWithMostPoints(Point[] points)
        {
            var circles = new Dictionary<(Point Center, double Radius), int>();

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        var circle = FindCircle(points[i], points[j], points[k]);
                        if (circle.HasValue)
                        {
                            var key = (circle.Value.Center, circle.Value.Radius);
                            if (circles.ContainsKey(key))
                            {
                                circles[key]++;
                            }
                            else
                            {
                                circles[key] = 3; // Initially, three points form the circle
                            }
                        }
                    }
                }
            }

            var bestCircle = circles.OrderByDescending(kvp => kvp.Value).FirstOrDefault();
            return new CircleResult
            {
                Center = bestCircle.Key.Center,
                Radius = bestCircle.Key.Radius,
                PointsCount = bestCircle.Value
            };
        }

        private Circle FindCircle(Point a, Point b, Point c)
        {
            double A = b.X - a.X;
            double B = b.Y - a.Y;
            double C = c.X - a.X;
            double D = c.Y - a.Y;

            double E = A * (a.X + b.X) + B * (a.Y + b.Y);
            double F = C * (a.X + c.X) + D * (a.Y + c.Y);

            double G = 2 * (A * (c.Y - b.Y) - B * (c.X - b.X));

            if (G == 0)
                return null;

            double centerX = (D * E - B * F) / G;
            double centerY = (A * F - C * E) / G;

            double radius = Math.Sqrt(Math.Pow(centerX - a.X, 2) + Math.Pow(centerY - a.Y, 2));

            return new Circle { Center = new Point(centerX, centerY), Radius = radius };
        }
    }

    class Program
    {
        static void Main()
        {
            CircleFinder finder = new CircleFinder();
            CircleFinder.Point[] points = {
            new CircleFinder.Point(0, 0),
            new CircleFinder.Point(1, 1),
            new CircleFinder.Point(2, 2),
            new CircleFinder.Point(3, 3),
            new CircleFinder.Point(4, 4),
            new CircleFinder.Point(5, 5)
        };

            var result = finder.FindCircleWithMostPoints(points);
            Console.WriteLine($"Center: ({result.Center.X}, {result.Center.Y}), Radius: {result.Radius}, Points: {result.PointsCount}");
        }
    }
}
