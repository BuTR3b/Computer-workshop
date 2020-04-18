using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_2
{
    public partial class Form1 : Form
    {
        int[,] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowArray_Click(object sender, EventArgs e)
        {
            int rows;
            int columns;
            Random num = new Random();
            textBox3.Clear();
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = num.Next(0, 9);
                    textBox3.Text += array[i, j] + " ";
                }
                textBox3.Text += "\r\n";
            }
        }

        private void BubbleSortRows_Click(object sender, EventArgs e)
        {
            int rows;
            int columns;
            int tmp;
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            textBox4.Clear();
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    for (int j = 0; j < columns - 1; j++)
                        if (array[i, j] > array[i, j + 1])
                        {
                            tmp = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = tmp;
                        }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    textBox4.Text += array[i, j] + " ";
                }
                textBox4.Text += "\r\n";
            }
        }

        private void BubbleSortColums_Click(object sender, EventArgs e)
        {
            int rows;
            int columns;
            int tmp;
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            textBox4.Clear();
            for (int i = 0; i < columns; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    for (int j = 0; j < rows - 1; j++)
                        if (array[j, i] > array[j + 1, i])
                        {
                            tmp = array[j, i];
                            array[j, i] = array[j + 1, i];
                            array[j + 1, i] = tmp;
                        }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    textBox4.Text += array[i, j] + " ";
                }
                textBox4.Text += "\r\n";
            }
        }

        private int FindMaxRowsI(int[] array, int row)
        {
            int rows;
            int columns;
            int max_i = 0;
            int max_elem = array[0];
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < columns - 1; i++)
            {
                if (array[i] < array[i])
                {
                    max_elem = array[i];
                    max_i = i;
                }
                /*for (int j = 0; j < columns; j++)
                {
                    if 
                }*/
            }
            return max_i;
        }

        private void BubbleSortRowsMax_Click(object sender, EventArgs e)
        {
            int rows;
            int columns;
            int max_i;
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            int max_elem = array[0,0];
            array = new int[rows, columns];
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < columns - 1; i++)
            {
                if (array[0, i] < array[0, i + 1])
                {
                    max_elem = array[0, i + 1];
                    max_i = i;
                }
                /*for (int j = 0; j < columns; j++)
                {
                    if 
                }*/
            }
            //textBox4.Text += max_i;
        }

        private void InsertRowsSort_Click(object sender, EventArgs e)
        {
            int rows;
            int columns;
            //int max_i;
            rows = Convert.ToInt32(textBox1.Text);
            columns = Convert.ToInt32(textBox2.Text);
            
        }

        private void InsertColumnsSort_Click(object sender, EventArgs e)
        {

        }
    }
}
