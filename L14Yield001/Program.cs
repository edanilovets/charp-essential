using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14Yield001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Power().GetEnumerator();
            foreach (string element in Power())
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
        static IEnumerable Power()
        {
            // yield - оператор автоматической генерации программных кодов итераторов
            // во что превращается этот код см. в UserCollection.cs
            yield return "Hello";
        }
        static IEnumerable Power1()
        {
            // yield break: указывает, что последовательность больше не имеет элементов
            // вернется пустая коллекцию
            yield break; 
        }
        static IEnumerable Power2()
        {
            while(true)
                yield return "Hello"; // Бесконечная коллекция
        }
    }
}
