using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xz
{
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("количество ядер {0} Name {1}",Environment.ProcessorCount, Environment.MachineName);

            Manager m = new Manager();
            m.CreateStudent();
            m.Display();
        }
    }
}
