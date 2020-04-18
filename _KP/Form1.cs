using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Form1 : Form
    {
        int rows;
        int columns;
        int[,] array;
        int less_count;
        int great_count;
        int divid;
        int not_divid;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            Random num = new Random();
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            array = new int[rows, columns];
            if (rows == columns)
            {
                MessageBox.Show("Матрица квадратная");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = num.Next(-50, 50);
                        textBox3.Text += array[i, j] + " ";
                    }
                    textBox3.Text += "\r\n";
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > 0)
                    {
                        great_count++;
                    }
                    else
                    {
                        less_count++;
                    }
                }
                if (less_count == great_count)
                {
                    textBox4.Text += less_count + "\r\n";
                }
                else
                {
                    textBox4.Text += 0 + "\r\n";
                }
                less_count = 0;
                great_count = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            Random num = new Random();
            array = new int[4, 8];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        array[i, j] = num.Next(0, 99);
                        textBox5.Text += array[i, j] + " ";
                        if (array[i, j] % 2 == 0)
                    {
                        divid++;
                    }
                        else
                    {
                        not_divid++;
                    }
                    }
                    textBox5.Text += "\r\n";
                textBox6.Text += "Чет - " + divid + " нечет - " + not_divid + "\r\n";
                divid = 0;
                not_divid = 0;
                }
        }
    }
}
