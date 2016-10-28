using System;
using System.Threading;
namespace _02_TimerExample
{
    class Program
    {
        static int sec = 10;
        static void TimerTick(object obj)
        {
            sec--;
            Console.WriteLine(sec.ToString());
            if (sec <= 0) {
                Timer a = (Timer)obj;
                a.Dispose();//Остановка таймера
                Console.WriteLine("Timer End");
            }
        }

        static void Main(string[] args)
        {
            TimerCallback timercallback = new TimerCallback(TimerTick);
            Timer timer = new Timer(timercallback);
            timer.Change(1000, 1000);//Запуск Таймера
            Console.ReadKey();//Задержка
        }
    }
}
