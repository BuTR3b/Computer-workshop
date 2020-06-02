using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[,] matrix;
        int[,] result;
        int M;
        int N;
        List<int> array = new List<int>();
        Random rand_num = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                M = Convert.ToInt32(textBox1.Text);
                N = Convert.ToInt32(textBox2.Text);
                matrix = new int[M, N];
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = rand_num.Next(1, 10);
                        textBox3.Text += matrix[i, j] + " ";
                    }
                    textBox3.Text += "\r\n";
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            array.Clear();
            M = Convert.ToInt32(textBox1.Text);
            N = Convert.ToInt32(textBox2.Text);
            int min;
            int tmp;
            int k = 0;
            if (M == N)
            {
                for (int j = 0; j < M / 2; j++)
                {
                    for (int i = j; i < N - j; i++)
                    {
                        array.Add(matrix[i, j]);
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((j >= i && j >= M - i - 1))
                        {
                            array.Add(matrix[i, j]);
                        }
                    }
                }
                for (int i = 0; i < array.Count - 1; i++)
                {
                    min = i;

                    for (int j = i + 1; j < array.Count; j++)
                    {
                        if (array[j] < array[min])
                        {
                            min = j;
                        }
                    }

                    if (min != i)
                    {
                        tmp = array[i];
                        array[i] = array[min];
                        array[min] = tmp;
                    }
                }
                for (int j = 0; j < M / 2; j++)
                {
                    for (int i = j; i < N - j; i++)
                    {
                        matrix[i, j] = array[k];
                        k++;
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((j >= i && j >= M - i - 1))
                        {
                            matrix[i, j] = array[k];
                            k++;
                        }
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        textBox4.Text += matrix[i, j] + " ";
                    }
                    textBox4.Text += "\r\n";
                }
            }
            else
            {
                MessageBox.Show("Матрица не квадратная");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
