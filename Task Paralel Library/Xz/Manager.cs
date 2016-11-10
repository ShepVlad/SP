using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xz
{
     public class Manager
    {
        List<Student> ls;
        string[] names = { "Slavick Nojenko", "Vova Kup",
            "Vlad Shepeluk", "Sultan", "Zlatov Slava" };
        int[] ages = { 19, 19, 17, 21, 25 };
        public Manager()
        {
            ls = new List<Student>();
        }
        public void CreateStudent()
        {
            Student s;
            for (int i = 0; i < 5; i++)
            {
                s = new Student(i+1, names[i], ages[i]);
                ls.Add(s);
            }
        }
        public void Display()
        {
            Console.WriteLine("Students->");
            foreach (Student s in ls)
            {
                s.Display();
            }
        }
    }
}
