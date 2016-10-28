using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //объект который мы можем создать в одном экземпляре
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton s1 = MySingleton.GetInstatnce();
            MySingleton s2 = MySingleton.GetInstatnce();
            MySingleton s3 = MySingleton.GetInstatnce();
            Guid g = Guid.NewGuid();
            Console.WriteLine("Guid {0}",g);
            Console.WriteLine("s1 {0}, s2 {1}, s3 {2}",s1.GetHashCode(),
                s2.GetHashCode(),s3.GetHashCode());

        }
    }
}
