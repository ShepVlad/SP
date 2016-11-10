using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xz
{
    public class Student
    {
        string name;
        int id;
        int age;
        public string  Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public Student()
        {
            name = "";
            id = 0;
            age = 0;
        }
        public Student(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("Id {0}, Name {1}, Age{2}", id, name, age);
        }
        
    }
}
