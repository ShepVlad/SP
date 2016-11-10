using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_TimerZBS
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            timer.Interval=1000;
            timer.Tick += Timer_Tick;
            timer.Start();

                


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           
           
            if(i%2!=0)
            {
                _lb.Items[0] ="item" + i;
            }
           else if(i%2==0)
            {
                _lb.Items[1] = "item" +i;
            }

            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            _lb.Items[0] = "item%1";
            _lb.Items[1] = "item%2";
        }
    }
}
