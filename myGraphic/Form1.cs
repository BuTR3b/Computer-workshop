using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGraphic
{
    public partial class Form1 : Form
    {
        public int step;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Graphics g = pictureBox1.CreateGraphics();
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.Color = textBox1.ForeColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = MyDialog.Color;
            //MessageBox.Show(Convert.ToString(MyDialog.Color));
            try
            {
                Pen Uppen = new Pen(MyDialog.Color, Convert.ToInt32(textBox2.Text));
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    g.DrawLine(Uppen, 20 + (i * 60), 200, 30 + (i * 60), 200);
                    g.DrawLine(Uppen, 30 + (i * 60), 200, 30 + (i * 60), 160);
                    g.DrawLine(Uppen, 30 + (i * 60), 160, 80 + (i * 60), 160);
                    g.DrawLine(Uppen, 80 + (i * 60), 160, 80 + (i * 60), 190);
                    g.DrawLine(Uppen, 80 + (i * 60), 190, 60 + (i * 60), 190);
                    g.DrawLine(Uppen, 60 + (i * 60), 190, 60 + (i * 60), 200);
                    g.DrawLine(Uppen, 60 + (i * 60), 200, 80 + (i * 60), 200);

                    g.DrawLine(Uppen, 20 + (i * 60), 210, 40 + (i * 60), 210);
                    g.DrawLine(Uppen, 40 + (i * 60), 210, 40 + (i * 60), 170);
                    g.DrawLine(Uppen, 40 + (i * 60), 170, 70 + (i * 60), 170);
                    g.DrawLine(Uppen, 70 + (i * 60), 170, 70 + (i * 60), 180);
                    g.DrawLine(Uppen, 70 + (i * 60), 180, 50 + (i * 60), 180);
                    g.DrawLine(Uppen, 50 + (i * 60), 180, 50 + (i * 60), 210);
                    g.DrawLine(Uppen, 50 + (i * 60), 210, 80 + (i * 60), 210);
                }
            }
            catch
            {
                MessageBox.Show("Введите значения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*step = Convert.ToInt32(textBox3.Text);
            Form2 forma = new Form2(step);
            forma.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
