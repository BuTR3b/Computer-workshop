using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_WIn
{
    public partial class Form1 : Form
    {
        int A_rows, A_colums, B_rows, B_colums, num_C;
        int[,] A;
        int[,] B;
        int[,] A_transp;
        int[,] B_transp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num_C = Convert.ToInt32(textBox9.Text);
            textBox8.Clear();
            for (int i = 0; i < A_rows; i++)
            {
                for (int j = 0; j < A_colums; j++)
                {
                    textBox8.Text += num_C * A[i, j] + " ";
                }
                textBox8.Text += "\r\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num_C = Convert.ToInt32(textBox9.Text);
            textBox8.Clear();
            for (int i = 0; i < B_rows; i++)
            {
                for (int j = 0; j < B_colums; j++)
                {
                    textBox8.Text += num_C * B[i, j] + " ";
                }
                textBox8.Text += "\r\n";
            }
        }

        private void button5_Click(object sender, EventArgs e) // умножить А на В
        {
            int[,] array = new int[A_rows, B_colums];
            textBox8.Clear();
            if (A_colums != B_rows)
            {
                MessageBox.Show("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }
            else
            {
                for (var i = 0; i < A_rows; i++)
                {
                    for (var j = 0; j < B_colums; j++)
                    {
                        array[i, j] = 0;
                        for (var k = 0; k < A_colums; k++)
                        {
                            array[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }
                for (int i = 0; i < A_rows; i++)
                {
                    for (int j = 0; j < B_colums; j++)
                    {
                        textBox8.Text += array[i, j] + " ";
                    }
                    textBox8.Text += "\r\n";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) // умножить В на А
        {
            int[,] array = new int[B_rows, A_colums];
            textBox8.Clear();
            if (B_colums != A_rows)
            {
                MessageBox.Show("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }
            else
            {
                for (var i = 0; i < B_rows; i++)
                {
                    for (var j = 0; j < A_colums; j++)
                    {
                        array[i, j] = 0;
                        for (var k = 0; k < B_colums; k++)
                        {
                            array[i, j] += B[i, k] * A[k, j];
                        }
                    }
                }
                for (int i = 0; i < B_rows; i++)
                {
                    for (int j = 0; j < A_colums; j++)
                    {
                        textBox8.Text += array[i, j] + " ";
                    }
                    textBox8.Text += "\r\n";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            A_transp = new int[A_colums, A_rows];
            for (int i = 0; i < A_rows; i++)
            {
                for (int j = 0; j < A_colums; j++)
                {
                    A_transp[j, i] = A[i, j];
                }
            }
            for (int i = 0; i < A_colums; i++)
            {
                for (int j = 0; j < A_rows; j++)
                {
                    textBox1.Text += A_transp[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            B_transp = new int[B_colums, B_rows];
            for (int i = 0; i < B_rows; i++)
            {
                for (int j = 0; j < B_colums; j++)
                {
                    B_transp[j, i] = B[i, j];
                }
            }
            for (int i = 0; i < B_colums; i++)
            {
                for (int j = 0; j < B_rows; j++)
                {
                    textBox7.Text += B_transp[i, j] + " ";
                }
                textBox7.Text += "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] array = new int[A_rows, A_colums];
            textBox8.Clear();
            if (A_rows == B_rows && A_colums == B_colums)
            {
                for (int i = 0; i < A_rows; i++)
                {
                    for (int j = 0; j < A_colums; j++)
                    {
                        array[i, j] = A[i, j] - B[i, j];
                        textBox8.Text += array[i, j] + " ";
                    }
                    textBox8.Text += "\r\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            A_rows = Convert.ToInt32(textBox2.Text);
            A_colums = Convert.ToInt32(textBox3.Text);
            int summa_colums = 0;
            A = new int[A_rows, A_colums];
            //textBox1.Text = "";
            textBox1.Clear();
            textBox4.Clear();
            for (int i = 0; i < A_rows; i ++)
            {
                for (int j = 0; j < A_colums; j++)
                {
                    A[i, j] = num.Next(10, 99);
                    textBox1.Text += A[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
            for (int j = 0; j < A_colums; j++)
            {
                for (int i = 0; i < A_rows; i++)
                {
                    summa_colums += A[i, j];
                }
                textBox4.Text += summa_colums + "\r\n";
                summa_colums = 0;
            }
            //textBox1.Text = rows + " " + colums;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            B_rows = Convert.ToInt32(textBox6.Text);
            B_colums = Convert.ToInt32(textBox5.Text);
            if (B_rows < 0 || B_colums < 0)
            {
                MessageBox.Show("Введены неверные значения");
                textBox6.Clear();
                textBox5.Clear();
            }
            else
            {
                B = new int[B_rows, B_colums];
                textBox7.Clear();
                for (int i = 0; i < B_rows; i++)
                {
                    for (int j = 0; j < B_colums; j++)
                    {
                        B[i, j] = num.Next(10, 99);
                        textBox7.Text += B[i, j] + " ";
                    }
                    textBox7.Text += "\r\n";
                }
            }        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] array = new int[A_rows, A_colums];
            textBox8.Clear();
            if (A_rows == B_rows && A_colums == B_colums)
            {
                for (int i = 0; i < A_rows; i++)
                {
                    for (int j = 0; j < A_colums; j++)
                    {
                        array[i, j] = A[i, j] + B[i, j];
                        textBox8.Text += array[i, j] + " ";
                    }
                    textBox8.Text += "\r\n";
                }
            }
        }
    }
}
