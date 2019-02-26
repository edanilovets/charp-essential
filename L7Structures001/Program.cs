using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Structures001
{
    class Program
    {
        struct MyStruct
        {
            private int field;
            public int Field
            {
                get { return field; }
                set { field = value; }
            }
            public void Show()
            {
                Console.WriteLine($"The field is: {Field}");
            }
        }
        static void Main(string[] args)
        {
            //Структура будет располагаться в куче (Heap), а не на стэке, потому что есть - new
            //Вызов конструктора по умолчанию
            MyStruct instance = new MyStruct();
            //instance.Field = 1;
            instance.Show();
            //Console.WriteLine(instance.Field);
            Console.ReadKey();
        }
    }
}
