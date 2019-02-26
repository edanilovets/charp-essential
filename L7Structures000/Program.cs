using System;

namespace L7Structures000
{
    class Program
    {
        //В структруре нельзя инициализировать поля в месте создания
        struct MyStruct
        {
            public int intField;
        }
        static void Main(string[] args)
        {
            //Создание экземпляра без вызова конструктора
            MyStruct instance;
            //Нельзя выводить неинициализированное поле
            //Console.WriteLine(instance.intField);
            instance.intField = 20;
            Console.WriteLine(instance.intField);
            Console.ReadKey();
        }
    }
}