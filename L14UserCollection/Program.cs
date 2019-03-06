using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Использование пользовательской коллекции
            UserCollection myCollection = new UserCollection();

            // Как устроен цикл foreach
            IEnumerable enumerable = myCollection as IEnumerable;
            IEnumerator enumerator = myCollection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("Name {0} with field1={1}, field2={2}", element.Name, element.Field1, element.Field2);
            }
            Console.ReadKey();
        }
    }
}
