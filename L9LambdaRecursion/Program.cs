using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Рекурсия в лямбда операторах

namespace L9LambdaRecursion
{
    delegate void MyDelegate(int argument);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate my = null; // Надо сначала обязательно присвоить что-то
            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin  {0}", i);
                if (i > 0)
                {
                    my(i); // Рекурсивный вызов
                }
                Console.WriteLine("End  {0}", i);
            };

            my(10);
            Console.ReadKey();
        }
    }
}
