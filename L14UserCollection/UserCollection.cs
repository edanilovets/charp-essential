using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14UserCollection
{
    // Класс UserCollection коллекция элементов Element
    // Для применения foreach - нужно чтобы класс реализовывал IEnumerable
    // "Iterator" Microsoft называет "Enumerator"
    public class UserCollection : IEnumerable, IEnumerator
    {
        Element[] elementsArray = null;
        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }
        // Указатель текущей позиции элемента в массиве
        int position = -1;

        // Реализация интерфейса IEnumerator: методы MoveNext, Reset и свойство Current
        public object Current
        {
            get { return elementsArray[position]; }
        }

        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }


        // Реализация интерфейса IEnumerable: метод GetEnumerator
        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
