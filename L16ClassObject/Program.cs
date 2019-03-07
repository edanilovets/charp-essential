using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Правило: переопределяйте GetHashCode переопределяя Equals

namespace L16ClassObject
{
    class Point
    {
        protected int x, y;
        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }
        // Переопределим метод Equals
        public override bool Equals(Object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }
        // Переопределим метод GetHashCode
        
        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 0);

            Console.WriteLine("a == b: {0}", a.Equals(b));
            Console.WriteLine("a == c: {0}", a.Equals(c));

            Console.WriteLine("HashCode of object a: {0}", a.GetHashCode());
            Console.WriteLine("HashCode of object b: {0}", b.GetHashCode());
            Console.WriteLine("HashCode of object c: {0}", c.GetHashCode());


            Console.ReadKey();
        }
    }
}
