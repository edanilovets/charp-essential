using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9Delegats001
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Hello from MyClass!");
        }
    }
    class MyNonStaticClass
    {
        public void Method()
        {
            Console.WriteLine("Hello from MyNonStaticClass!");
        }
        public string PrintHello(string name)
        {
            return "Hello " + name;
        }
    }
    public delegate void MyDelegate();
    public delegate string PrintDelegate(string param);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke(); // Способ вызова делегата 1
            myDelegate(); // Способ вызова делегата 2

            MyNonStaticClass instance = new MyNonStaticClass();
            myDelegate = new MyDelegate(instance.Method);
            myDelegate();

            PrintDelegate print = new PrintDelegate(instance.PrintHello);
            string hello = print.Invoke("Jeffrey Richter");
            Console.WriteLine(hello);

            Console.ReadKey();
        }
    }
}
