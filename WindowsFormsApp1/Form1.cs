using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int M, N;
        int[,] matr;
        Random a = new Random();
        Random K = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            M = Convert.ToInt32(textBox3.Text);
            N = Convert.ToInt32(textBox4.Text);
            matr = new int[M, N];
            int k = 0;
            k = K.Next(1, N);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matr[i, j] = a.Next(1, 10);
                    textBox1.Text += matr[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j >= k)
                    {
                        matr[i, j] = 1;
                        textBox2.Text += matr[i, j] + " ";
                    }
                    else
                    {
                        textBox2.Text += matr[i, j] + " ";
                    }
                }
                textBox2.Text += "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            bool sort = true;
            int count = 0;
            M = Convert.ToInt32(textBox3.Text);
            N = Convert.ToInt32(textBox4.Text);
            matr = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matr[i, j] = a.Next(1, 10);
                    textBox1.Text += matr[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
            for (int i = 0; i < M; i++)
            {
                sort = true;
                for (int j = 0; j < N - 1; j++)
                {
                    if (matr[i , j] > matr[i, j + 1])
                    {
                        sort = false;
                        break;
                    }
                }
                if (sort)
                {
                    count++;
                }
            }
            textBox2.Text += count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            int max = 0;
            int max_ind = 0;
            int q;
            M = Convert.ToInt32(textBox3.Text);
            N = Convert.ToInt32(textBox4.Text);
            matr = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matr[i, j] = a.Next(1, 10);
                    textBox1.Text += matr[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
            for (int i = 0; i < M; i ++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matr[i, j] > max)
                    {
                        max = matr[i, j];
                        max_ind = j;
                    }
                }
                q = matr[i, 0];
                matr[i, 0] = max;
                matr[i, max_ind] = q;
                max = 0;
                max_ind = 0;
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    textBox2.Text += matr[i, j] + " ";
                }
                textBox2.Text += "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            M = Convert.ToInt32(textBox3.Text);
            matr = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matr[i, j] = a.Next(1, 10);
                    textBox1.Text += matr[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i + j >= M - 1)
                    {
                        matr[i, j] = 0;
                    }
                    textBox2.Text += matr[i, j] + " ";
                }
                textBox2.Text += "\r\n";
            }
;        }
    }
}
