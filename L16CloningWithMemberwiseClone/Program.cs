using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


// Клонирование с помощью MemberwiseClone()
// Преимущество клонирования с помощью MemberwiseClone() в том, что
// при клонировании не вызывается конструктор, а клонирование происходит через
// копирование дампа памяти - тела оригинала

namespace L16CloningWithMemberwiseClone
{
    class MyClass: ICloneable
    {
        int a, b;
        public MyClass()
        {
            // Делаем задежки чтобы экземпляр класса строился долго
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            // Клонируем текущий экземпляр
            return this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Тестировщики используют для замера производительности Stopwatch
            // он точнее чем DateTime
            Stopwatch timer = new Stopwatch();

            // Замер времени построения оригинала
            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();
            Console.WriteLine("Original is built in {0} ms", timer.Elapsed.TotalMilliseconds);

            timer.Reset();

            // Замер времени построения клона
            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine("Clone is built in {0} ms", timer.Elapsed.TotalMilliseconds);

            // Delay
            Console.ReadKey();
        }
    }
}
