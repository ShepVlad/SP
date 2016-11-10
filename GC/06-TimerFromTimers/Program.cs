using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _06_TimerFromTimers
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.WriteLine("Enter for Stop Timer"); ;
            Console.ReadKey();
            timer.Stop();
            Console.WriteLine("Enter for Stop Timer"); ;
            Console.ReadKey();
            timer.Start();
            Console.ReadKey();

            timer.Dispose();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Tick {0}",e.SignalTime);
        }
    }
}
