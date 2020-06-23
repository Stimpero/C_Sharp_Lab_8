using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0%";
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(t_Tick);
            timer1.Start();

        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            label1.Text = progressBar1.Value + "%";
            if (progressBar1.Value>= 100) timer1.Stop();
        }

}
}
