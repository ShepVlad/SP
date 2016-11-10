using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    class Test
    {
        [Key]
        public int MyId { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test() { MyId = 1, Name = "11111322323444" };
            Console.WriteLine(test.Name);
        }
    }
}
