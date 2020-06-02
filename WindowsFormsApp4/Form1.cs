using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        ColorDialog Mycolor;
        int x0;
        int y0;
        int x1;
        int y1;
        int size;
        int direction;
        int angle;
        public Form1()
        {
            InitializeComponent();
        }

        void draw_line(int x, int y)
        {
            pictureBox1.Image = null;
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Mycolor.Color, size);
            g.DrawLine(pen, x0, y0, x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                Graphics g = pictureBox1.CreateGraphics();
                ColorDialog MyDialog = new ColorDialog();
                MyDialog.AllowFullOpen = true;
                MyDialog.Color = textBox1.ForeColor;
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    textBox1.ForeColor = MyDialog.Color;
                Pen pen = new Pen(MyDialog.Color, Convert.ToInt32(textBox3.Text));
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(textBox2.Text); j++)
                    {
                        g.DrawLine(pen, 10 + (i * 20), 10 + (j * 20), 90 + (i * 20), 10 + (j * 20));
                        g.DrawLine(pen, 10 + (i * 20), 10 + (j * 20), 50 + (i * 20), 30 + (j * 20));
                        g.DrawLine(pen, 50 + (i * 20), 30 + (j * 20), 90 + (i * 20), 10 + (j * 20));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Поля не заполнены");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Mycolor = new ColorDialog();
            Mycolor.AllowFullOpen = true;
            Mycolor.Color = textBox1.ForeColor;
            if (Mycolor.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = Mycolor.Color;
            try
            {
                size = Convert.ToInt32(textBox4.Text);
                if (radioButton1.Checked)
                {
                    direction = 1;
                }
                else
                {
                    direction = -1;
                }
                angle = Convert.ToInt32(textBox5.Text) * direction;
                x0 = pictureBox1.Width / 2;
                y0 = pictureBox1.Height / 2;
                x1 = x0 + pictureBox1.Width / 4;
                y1 = y0;
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(x0 + (x1 - x0) * Math.Cos(angle) - (y1 - y0) * Math.Sin(angle));
            y1 = Convert.ToInt32(y0 + (y1 - y0) * Math.Cos(angle) + (x1 - x0) * Math.Sin(angle));
            angle += angle;
            draw_line(x1, y1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }
    }
}
