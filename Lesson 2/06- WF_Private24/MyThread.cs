using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06__WF_Private24
{
    class MyThread
    {
        public Thread Thrd;
        ListBox listbox;
      
        void Run()
        {
            for (int i = 0; i < 30; i++) {
                listbox.Items.Add("Item" + i.ToString());
                Thread.Sleep(400);

            }
        }
        public MyThread(ListBox lb)
        {
            listbox = lb;
            Thrd = new Thread(Run);
            Thrd.Start();
        }
    }
}
