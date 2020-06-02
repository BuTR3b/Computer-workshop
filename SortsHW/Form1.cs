using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortsHW
{
    public partial class Form1 : Form
    {
        public int[,] array;
        public int[,] sorted_array;
        public int M;
        public int N;
        Random num = new Random();
        List<int> my_list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        void swap(int num1, int num2)
        {
            int tmp = num1;
            num1 = num2;
            num2 = tmp;
        }
        List<int> bubble_sort_plus(List<int> list)
        {
            bool n = true;
            while (n)
            {
                n = false;
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                        n = true;
                    }
                }
            }
            return list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            M = Convert.ToInt32(textBoxM.Text);
            N = Convert.ToInt32(textBoxN.Text);
            array = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = num.Next(1, 10);
                    textBox1.Text += array[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            my_list.Clear();
            sorted_array = new int[M, N];
            if (M == N)
            {
                for (int i = 0; i < M; i++)
                {
                    for (int j = i; j >= N - i - 1; j--)
                    {
                        my_list.Add(array[i, j]);
                    }
                }
                my_list = bubble_sort_plus(my_list);
                int elem = my_list.Count - 1;
                for (int i = 0; i < M; i++)
                {
                    for (int j = i; j >= N - i - 1; j--)
                    {
                        array[i, j] = my_list[elem];
                        elem--;
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        textBox2.Text += array[i, j] + " ";
                    }
                    textBox2.Text += "\r\n";
                }
            }
            else
            {
                textBox2.Text += "МАТРИЦА НЕ КВАДРАТНОГО ВИДА";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int tmp;
            int q;
            int key;
            int[] sum = new int[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    sum[i] += array[j, i];
                    textBox2.Text += array[j,i] + " ";
                }
                textBox2.Text += " = " + sum[i];
                textBox2.Text += "\r\n";
            }
            for (int i = 1; i < N; i++)
            {
                if (sum[i] < sum[i - 1])
                {
                    tmp = sum[i];
                    sum[i] = sum[i - 1];
                    sum[i - 1] = tmp;
                    for (int k = 0; k < M; k++)
                    {
                        tmp = array[k, i];
                        array[k, i] = array[k, i - 1];
                        array[k, i - 1] = tmp;
                    }
                }
            }
            /*for (int i = 0; i < N; i++)
            {
                q = i;
                key = sum[i];
                while (sum[q - 1] > key && q > 1) // выходит за границы
                {
                    tmp = sum[q - 1];
                    sum[q - 1] = sum[q];
                    sum[q] = tmp;
                    q--;
                }
                sum[q] = key;
            }*/
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    textBox2.Text += array[i,j] + " ";
                }
                textBox2.Text += "\r\n";
            }
        }
    }
}
