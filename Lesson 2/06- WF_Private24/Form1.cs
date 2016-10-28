using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06__WF_Private24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void getData_Click(object sender, EventArgs e)
        {

        //  MyThread thr1 = new MyThread(lbTest);

           Private24 pr24 = new Private24(lpPrivate24, new DateTime(2016, 9, 1));

        }
    }
}
