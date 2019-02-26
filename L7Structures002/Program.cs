using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Structures002
{
    struct MyStruct
    {
        //Структуры могут содержать статические поля
        public static int StaticField
        {
            get; set;
        }

        //Структуры могут содержать статические методы
        public static void Show()
        {
            Console.WriteLine(StaticField);
        }

        //Нельзя явно создать констуктор по умолчанию
        //public MyStruct() {  }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct.Show();
        }
    }
}