using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04_CreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName("CarLibrary.dll")); //получаем необходимый модуль этой сборки

            Module mod = assembly.GetModule("CarLibrary.dll");

            foreach (Type t in mod.GetTypes())

                Console.WriteLine(t.FullName); 
            Type type = assembly.GetType("CarLibrary.MiniVan");

            object o1 = Activator.CreateInstance(type,
                new object[] { "Test", (short)50, (short)40 });
            MethodInfo method = type.GetMethod("Acceleration");

            method.Invoke(o1, null);

        }
    }
}
