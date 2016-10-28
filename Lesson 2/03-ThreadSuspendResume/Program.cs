using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _03_ThreadSuspendResume
{
    public class MyThread
    {
        public Thread Thrd;
        public MyThread()
        {
            Thrd = new Thread(new ThreadStart(Run));
            Thrd.Start();
        }
        void Run()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < 70; i++) {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyThread tread = new MyThread();
            
            tread.Thrd.Suspend();
            for (int i = 0; i < 100; i++) {
                Console.Write("--");
                Thread.Sleep(200);//
            }
            Console.WriteLine("--------------------");
            tread.Thrd.Resume();//Продолжает !Устаревший!
        }
    }
}
