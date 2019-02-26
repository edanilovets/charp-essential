using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8Enums
{
    // При компиляции, компилятор подставляет вместо имен установленные значения [имя]=[число]
    // По умолчанию тип значения - int
    // Можно использовать любой целый тип C# (byte, sbyte, short, ushort, int, uint, long, ulong)

    enum EnumType : byte // Явно указываем тип
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Infinite = 255
    }
    class Program
    {

        static void Main(string[] args)
        {
            EnumType digit = EnumType.One;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);

            Enum one = EnumType.One; // EnumType наследуется от Enum

            Console.WriteLine(new String('-', 10));

            // Можно вывести в цикле
            for (EnumType i = EnumType.Zero; i <= EnumType.Three; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new String('-', 10));

            // Форматированный вывод
            Console.WriteLine("Hex: {0}", Enum.Format(typeof(EnumType), EnumType.Infinite, "x"));
            Console.WriteLine("Dec: {0}", Enum.Format(typeof(EnumType), EnumType.Infinite, "D"));
            Console.WriteLine("Str: {0}", Enum.Format(typeof(EnumType), EnumType.Infinite, "G"));

            Console.WriteLine(new String('-', 10));

            // Enum.GetValues() - возвращает экземпляр System.Array
            Array array = Enum.GetValues(typeof(EnumType));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Name: {0}, value: {0:D}", array.GetValue(i));
            }

            Console.ReadKey();
        }
    }
}