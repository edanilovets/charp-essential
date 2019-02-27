using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9Delegats002
{
    // Делегат
    public delegate void MyDelegate();
    class Program
    {
        // Методы
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            // Другой синтаксис - Техника предположения делегата
            // MyDelegate myDelegate1 = Method1;

            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);




            // Комбинируем делегаты
            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;
            Console.WriteLine("Enter number from 1 to 5");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        myDelegate1.Invoke();
                        break;
                    }
                case "2":
                    {
                        myDelegate2.Invoke();
                        break;
                    }
                case "3":
                    {
                        myDelegate3.Invoke();
                        break;
                    }
                case "4":
                    {
                        MyDelegate myDelegate4 = myDelegate - myDelegate1; // Расгрупировка делегата
                        myDelegate4.Invoke();
                        break;
                    }
                case "5":
                    {
                        myDelegate.Invoke();
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
