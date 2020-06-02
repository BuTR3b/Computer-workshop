using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myFraction fract1 = new myFraction();
            textBox1.Text += fract1.ToString() + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myFraction fract2 = new myFraction(2);
            textBox1.Text += fract2.ToString() + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myFraction fract3 = new myFraction(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox1.Text += fract3.ToString() + "\r\n";
        }
    }
}
