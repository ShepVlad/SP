using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CleanTresh
{
    class Test
    {
        int[] array = new int[10000000];
        public void Method(int i)
        {
            Console.WriteLine(i);
        }
        ~Test()
        {
            Console.WriteLine("Объект {0} Удален",this.GetHashCode());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test[] array = new Test[1000];
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    //array[i] = new Test();
                    //array[i].Method(i);
                    Test t = new Test();

                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("{0}", exc.Message);
             
            }
            Console.ReadKey();
        }
    }
}
