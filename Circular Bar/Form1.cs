using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circular_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value = (int)pfcCPU.NextValue();
            label1.Text = "" + " " + circularProgressBar1.Value.ToString() + " " + "%";

            circularProgressBar2.Value = (int)pfcRAM.NextValue();
            label2.Text = "Free: " + " " + circularProgressBar2.Value.ToString() + " " + "MBytes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
