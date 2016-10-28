using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01_TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {

            TimerCallback timercallback = new TimerCallback(TimerTick);
            Timer timer = new Timer(timercallback);
            timer.Change(2000, 500);//Запуск Таймера
            Console.ReadKey();//Задержка

        }
        static void TimerTick(object a) {
            Timer t = a as Timer;
            //t.Dispose;
            Console.WriteLine("Hello Timer");
        }
    }
}
