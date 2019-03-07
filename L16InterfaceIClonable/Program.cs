using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16InterfaceIClonable
{
    // Deep Copy (return new Point)
    // Интерфейс ICloneablex
    public class Point : ICloneable
    {
        public int x, y;
        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // Реализация интерфейса ICloneable
        public object Clone()
        {
            return new Point(this.x, this.y) as object;
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("First checking:");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Modify clone.x (original.x stays same)
            clone.x = 0;
            Console.WriteLine("Second checking:");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Delay
            Console.ReadKey();
        }
    }
}
