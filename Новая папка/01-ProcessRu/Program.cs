using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ProcessRu
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proc = new Process();
            proc.StartInfo = new System.Diagnostics.ProcessStartInfo("calc.exe");
            proc.Start();


            proc.WaitForExit();
            Console.WriteLine("Calc process END");
            //proc.ProcessName = "calc.exe";

        }
    }
}
