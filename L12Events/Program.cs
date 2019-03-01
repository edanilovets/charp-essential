using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// События

namespace L12Events
{
    public delegate void EventDelegate();
    public class MyClass
    {
        public event EventDelegate MyEvent = null; // событие, только тип delegate
        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
    class Program
    {
        // Методы обработчики события
        static private void Handler1()
        {
            Console.WriteLine("Handler1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Handler2");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            // Присоединение обработчика события
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += Handler2;

            // Метод который вызывает событие
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            instance.MyEvent -= Handler1; // Открепляем метод Handler1
            //instance.MyEvent -= Handler2;
            instance.InvokeEvent();


            Console.ReadKey();
        }
    }
}
