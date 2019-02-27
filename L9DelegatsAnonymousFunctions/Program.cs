using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Анонимные (лямбда) методы (нет имени)

namespace L9DelegatsAnonymousFunctions
{
    // Создаем класс делегата
    public delegate void MyDelegate();
    public delegate int SumDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр делегата и сообщаем с ним анонимный метод
            // Техника предположение делегата
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world"); };

            // Можно сделать через конструктор
            //MyDelegate myDelegate = new MyDelegate(delegate { Console.WriteLine("Hello world"); });

            myDelegate();

            SumDelegate Sum = delegate (int a, int b) { return a + b; };
            Console.WriteLine(Sum(5, 20));

            Console.ReadKey();
        }
    }
}
