using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ограничения параметров типа

namespace L11GenericsConstraints
{
    class MyClass1<T> where T : class
    {
        public T variable;
    }
    class MyClass2<T> where T : struct
    {
        public T variable;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1<string> instance1 = new MyClass1<string>();
            //MyClass1<int> instance2 = new MyClass1<int>(); // Ошибка int - структурный тип

            //MyClass2<string> instance3 = new MyClass2<string>(); // Ошибка string - ссылочный тип
            MyClass2<int> instance4 = new MyClass2<int>();
        }
    }
}
