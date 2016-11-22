using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ListAllProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Список процессов";
            //изменяем размер буфера консоли и окна на необходимый нам
            //Console.WindowWidth = 40;
            //Console.BufferWidth = 40; //получаем список процессов

            var processes = Process.GetProcesses().OrderBy(p=>p.MachineName); //выводим заголовок

            Console.WriteLine(" {0,-50}\t{1,-10}", "Имя процесса:", "PID:"); //для каждого процесса выводим имя и PID
            foreach (Process p in processes)
                Console.WriteLine("	{0,-50}\t{1,-10}", p.ProcessName, p.Id);

        }
    }
}
