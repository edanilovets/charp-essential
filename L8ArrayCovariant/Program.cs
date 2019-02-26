using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8ArrayCovariant
{
    class Program
    {
        public interface IAnimal
        {
            void Voice();
        }
        public struct Dog : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Bark");
            }
        }
        static void Main(string[] args)
        {
            // 1 - Массив структурного типа не ковариантен
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };
            IAnimal[] animals = dogs; // Ковариантность

            // 2
            int[] vector = new int[3] { 1, 2, 3 };
            object[] array = vector;

        }
    }
}