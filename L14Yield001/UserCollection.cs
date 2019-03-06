using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L14Yield001
{
    class UserCollection
    {
        // Во что превратился метод Power() в NetReflector из Program.cs
        public static IEnumerable Power()
        {
            return new ClassPower(-2);
        }

        // Создался нестед класс
        private sealed class ClassPower : IEnumerable<object>, IEnumerator<object>, IEnumerator, IDisposable
        {
            // Поля
            private int state;
            private object current;
            private int initialThreadId;

            // Конструктор
            public ClassPower(int state)
            {
                this.state = state;
                this.initialThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            //Реализация интерфейсов...
        }
    }
}
