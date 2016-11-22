using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_WinFormProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            process.StartInfo = new System.Diagnostics.ProcessStartInfo("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.CloseMainWindow();
            process.Close();
        }
    }
}
