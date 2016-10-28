using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class MySingleton
    {
        static private MySingleton singleton;

        private static object lockObj = new object();
        static MySingleton()
        {
            Console.WriteLine("Work Static ctor.");
        }
        private MySingleton() {/*инициализация чего то*/}
        public static MySingleton GetInstatnce()
        {
            if (singleton==null) {
             //   lock (typeof(MySingleton)) {
                    lock(lockObj)
                    if (singleton == null) {
                        singleton = new MySingleton();
                    }
               // }
            }
            return singleton;
        }
    }
}
