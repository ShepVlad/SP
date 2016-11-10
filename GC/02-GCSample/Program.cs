using System;
using System.Threading;

namespace _02_GCSample
{
    class GarbageHelper
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                var p = new Person();
            }
        }
        class Person
        {
            private string _name; private string _surname; private byte _age;

            public Person(string name, string surname, byte age)
            {
                this._age = age; this._name = name; this._surname = surname;
            }

            public Person() : this("", "", 0)
            {
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(2000); 
            Console.WriteLine("Занято памяти  на старте  (байт): {0}", GC.GetTotalMemory(false));
            //forceFullCollection
            //     true , чтобы указать, что перед возвратом этот метод может дождаться выполнения сборки мусора; в противном случае — false.
            GarbageHelper hlp = new GarbageHelper();
            // Узнаем поколение, в котором находится объект
            Console.WriteLine("Поколение объекта GarbageHelper hlp: {0}", GC.GetGeneration(hlp));
            // Количество занятой памяти
            Console.WriteLine("Занято памяти (байт): {0}", GC.GetTotalMemory(false));
            // Создаем мусор
            hlp.MakeGarbage();
            Console.WriteLine("Занято памяти (байт): {0} after MakeGarbage", GC.GetTotalMemory(false));
            // Вызываем явный сбор мусора в первом поколении
            GC.Collect(0);
            // Количество занятой памяти
            Console.WriteLine("Занято памяти (байт): {0} после GC.Collect(0)", GC.GetTotalMemory(false));
            // Узнаем поколение, в котором находится объект
            Console.WriteLine("Поколение объекта GarbageHelper hlp: {0}", GC.GetGeneration(hlp));
            // Вызываем явный сбор мусора во всех поколениях
            GC.Collect();
            // Количество занятой памяти
            Console.WriteLine("Поколение объекта GarbageHelper hlp: {0} после GC.Collect()", GC.GetGeneration(hlp));
            Console.WriteLine("Занято памяти (байт): {0}", GC.GetTotalMemory(false));
        }
    }
}
