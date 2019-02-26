using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Boxing - преобразование структурного в ссылочный тип
// Unboxing - преобразование ссылочного типа в структурный
// Стоит ли использовать Boxing и Unboxing?
// Несомненно в некоторых ситуациях да. Не стоит злоупотреблять, эти операции
// работают с кучей и много объктов может привести к потере ресурсов
namespace L8BoxingUnboxing
{
    interface IInterface
    {
        void Method();
    }
    struct MyStruct : IInterface //: ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            short a = 25;
            // Boxing: Упаковка переменной
            object o = a;
            // UnBoxing: Распаковка объетка
            short b = (short)o;
            // Распаковка должна производится только в тот тип, из которого была упаковка
            // byte s = (byte)o;
            MyStruct my;
            my.Method();
            // Boxing
            IInterface boxed = my;
            boxed.Method();
            // UnBoxing
            MyStruct unBoxed = (MyStruct)boxed;

            Console.ReadKey();
        }
    }
}