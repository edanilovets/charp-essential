using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Лямбда выражения и лямбда операторы

namespace L9Lambda001
{
    public delegate int MyDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            // Конструкции функционального программирования
            myDelegate = delegate (int x) { return x * x; }; // Лямбда метод
            myDelegate = (x) => { return x * x; };  // Лямбда оператор (=> - аргумент х входит в тело)
            myDelegate = x => x * x;                // Лямбда выражение (может содержать только 1 выражение)

            int result = myDelegate(4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
