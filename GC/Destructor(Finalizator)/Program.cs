using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Destructor_Finalizator_
{
    class ResourceWrapper
    {
        ~ResourceWrapper()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ResourceWrapper recsource = new ResourceWrapper();
            // GC.Collect();
            // recsource = null;
            //   Console.WriteLine("\n\nНажмите любую клавишу для завершения работы");
            Timer timer = new Timer(Tick, "tick", 1000,500);

          
          Console.ReadKey();
          
         
            timer.Dispose();
            using (SqlConnection con = new SqlConnection())
            {

            }
        }
        static void Tick(object state)
        {
            Console.WriteLine("{0}",state);
            GC.Collect();
        }
    }
}
