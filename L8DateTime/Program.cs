using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Структура DateTime представляет текущее время, обычно выраженное как дата и время суток
// Типа значения DateTime - дата и время в диапазоне от 00:00:00 1.02.0001 до 23:59:59 31.01.9999

namespace L8DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current date and time: {0}", now);
            Console.WriteLine("Year: {0}", now.Year);
            Console.WriteLine("Month: {0}", now.Month);
            Console.WriteLine("Day: {0}", now.Day);
            Console.WriteLine("Day of week: {0}", now.DayOfWeek);
            Console.WriteLine("Day of year: {0}", now.DayOfYear);
            Console.WriteLine("Date: {0}", now.Date);

            // Создание новой даты
            DateTime newYearDate = new DateTime(2020, 1, 1);
            DateTime today = DateTime.Now;

            TimeSpan left = newYearDate - today;
            Console.WriteLine("New Year is in: " + left.Days + " days");

            // Создание новой даты и времени
            DateTime newDate = new DateTime(2020, 1, 1, 23, 11, 11);

            // Форматированный вывод даты и времени
            Console.WriteLine();
            Console.WriteLine("Format: {0:D}", newDate);
            Console.WriteLine("Format: {0:d}", newDate);
            Console.WriteLine("Format: {0:F}", newDate);
            Console.WriteLine("Format: {0:f}", newDate);
            Console.WriteLine("Format: {0:G}", newDate);
            Console.WriteLine("Format: {0:g}", newDate);
            Console.WriteLine("Format: {0:M}", newDate);
            Console.WriteLine("Format: {0:Y}", newDate);
            Console.WriteLine("Format: {0:T}", newDate);
            Console.WriteLine("Format: {0:t}", newDate);

            // Преобразует строку в DateTime
            Console.WriteLine();
            Console.WriteLine(DateTime.Parse("3/12/2019"));
            Console.WriteLine(DateTime.Parse("5 march 2018")); // Месяц на языке OS

            Console.ReadKey();
        }
    }
}