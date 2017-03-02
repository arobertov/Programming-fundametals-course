using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionCircles
{
    class IntersectCircles
    {
        static void Main()
        {
            var c1Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c2Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point firstCircle = GetCircle(c1Arr);
            Point secondCircle = GetCircle(c2Arr);
            bool isInterection = GetIsInterection(firstCircle, secondCircle);
            if (isInterection) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        private static bool GetIsInterection(Point firstCircle, Point secondCircle)
        {
            var deltaX = firstCircle.X - secondCircle.X;
            var deltaY = firstCircle.Y - secondCircle.Y;
            var dist = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            var intersect = (dist - (firstCircle.R + secondCircle.R));
            if (intersect <= 0)
            {
                return true;
            }
            else return false;
        }

        private static Point GetCircle(int[] arr)
        {
            Point c = new Point();
            c.X = arr[0];
            c.Y = arr[1];
            c.R = arr[2];
            return c;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }
}
