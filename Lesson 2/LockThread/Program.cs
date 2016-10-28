using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LockThread
{
    class Program
    {
        static object locObj = new object();
        private static ReaderWriterLockSlim _readWriteLock =
            new ReaderWriterLockSlim();
        static void Run1()
        {
            for (int i = 0; i < 100; i++) {
                if (i%2==1) {
                    lock (locObj) {
                        _readWriteLock.EnterWriteLock();
                        using (StreamWriter sw = new StreamWriter("test.dat", true)) {
                            sw.WriteLine(i);
                            sw.Close();
                        }
                        _readWriteLock.ExitWriteLock();
                        Console.WriteLine("{0} Save {1}",Thread.CurrentThread.GetHashCode(),i);
                    }
                }
                Thread.Sleep(70);
            }
        }

        static void Run2()
        {
            for (int i = 0; i < 100; i++) {
                if (i % 2 == 0) {
                    lock (locObj) {
                        _readWriteLock.EnterWriteLock();
                        using (StreamWriter sw = new StreamWriter("test.dat", true)) {
                            sw.WriteLine(i);
                            sw.Close();
                        }
                        _readWriteLock.ExitWriteLock();
                        Console.WriteLine("{0} Save {1}", Thread.CurrentThread.GetHashCode(), i);
                    }
                }
                Thread.Sleep(70);
            }
        }
        static void Main(string[] args)
        {
            if(!File.Exists("test.dat")) {
                File.Create("test.dat");
            }
            Thread.Sleep(2000);
            Thread th2 = new Thread(new ThreadStart(Run2));
            th2.Start();
            Thread th1 = new Thread(new ThreadStart(Run1));
            th1.Start();
        }
    }
}
