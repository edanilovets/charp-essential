using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7StructInStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct_1MB my = new MyStruct_1MB();
            Console.WriteLine(my.GetType());
            Console.ReadKey();
        }
    }
}