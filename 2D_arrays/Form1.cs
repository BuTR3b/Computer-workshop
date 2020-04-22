using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_arrays
{
    public partial class Form1 : Form
    {
        int rows, colums;
        int[,] array_orig;
        int[,] array_new;
        int[] array_index;
        Random num;

        public Form1()
        {
            InitializeComponent();
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox4.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            try
            {
                rows = Convert.ToInt32(textBox1.Text);
                colums = Convert.ToInt32(textBox2.Text);
                num = new Random();
                array_orig = new int[rows, colums];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        array_orig[i, j] = num.Next(-9, 9);
                        textBox3.Text += array_orig[i, j] + " ";
                    }
                    textBox3.Text += "\r\n";
                }
            }
            catch
            {
                MessageBox.Show("Введите размер массива");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            array_index = new int[rows];
            textBox4.Clear();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array_orig[i, j] == i + j)
                    {
                        array_index[i] = 1;
                    }
                    else
                    {
                        array_index[i] = 0;
                    }
                }
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array_index[i] == 0)
                    {
                        textBox4.Text += array_orig[i, j] + " ";
                    }
                }
                textBox4.Text += "\r\n";
                //textBox4.Text += array_index[i] + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            rows = Convert.ToInt32(textBox1.Text);
            array_new = new int[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array_new[i, j] = num.Next(-9, 9);
                    textBox3.Text += array_new[i, j] + " ";
                }
                textBox3.Text += "\r\n";
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (array_new[i, j] == array_new[j, i])
                    {
                        textBox4.Text += array_new[i, j] + " ";
                    }
                    else
                    {
                        textBox4.Clear();
                        textBox4.Text += "Массив не симметричен";
                        break;
                    }
                }
                textBox4.Text += "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max = -10;
            int min = 10;
            int index_max = 0;
            int index_min = 0;
            int tmp;
            //textBox3.Clear();
            textBox4.Clear();
            //array_orig = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array_orig[i, j] > max)
                    {
                        max = array_orig[i, j];
                        index_max = j;
                    }
                    else 
                    if (array_orig[i, j] < min)
                    {
                        min = array_orig[i, j];
                        index_min = j;
                    }
                }
                tmp = array_orig[i, index_min];
                array_orig[i, index_min] = array_orig[i, index_max];
                array_orig[i, index_max] = tmp;
                max = -10;
                min = 10;
                index_max = 0;
                index_min = 0;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    textBox4.Text += array_orig[i, j] + " ";
                }
                textBox4.Text += "\r\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            int max = -10;
            int max_index = 0;
            int tmp;
            rows = Convert.ToInt32(textBox1.Text);
            array_new = new int[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array_new[i, j] = num.Next(-9, 9);
                    textBox3.Text += array_new[i, j] + " ";
                }
                textBox3.Text += "\r\n";
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (array_new[i, j] > max)
                    {
                        max = array_new[i, j];
                        max_index = j;
                    }
                }
                tmp = array_new[i, i];
                array_new[i, i] = array_new[i, max_index];
                array_new[i, max_index] = tmp;
                max = -10;
                max_index = 0;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    textBox4.Text += array_new[i, j] + " ";
                }
                textBox4.Text += "\r\n";
            }
        }
    }
}
