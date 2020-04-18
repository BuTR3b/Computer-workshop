using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_str
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string my_str = textBox1.Text;
            string new_str = "";
            for (int i = 0; i < my_str.Length; i++)
            {
                if (my_str[i] != '*')
                {
                    new_str += my_str[i];
                }
            }
            textBox2.Text = new_str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string my_str = textBox3.Text;
            string new_str = "";
            char to_del = Convert.ToChar(textBox4.Text);
            for (int i = 0; i < my_str.Length; i++)
            {
                if (my_str[i] != to_del)
                {
                    new_str += my_str[i];
                }
            }
            textBox2.Text = new_str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string my_str = textBox6.Text + ' ';
            string new_str = "";
            string to_del = textBox5.Text;
            for (int i = 0; i < my_str.Length - 1; i++)
            {
                if (my_str[i] == to_del[0] && my_str[i + 1] == to_del[1])
                {
                    i++;
                }
                else 
                {
                    new_str += my_str[i];
                }
            }
            textBox2.Text = new_str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string my_str = textBox11.Text;
            string new_str = "";
            for (int i = 0; i < my_str.Length; i++)
            {
                if (my_str[i] != '*')
                {
                    new_str += my_str[i];
                }
                else
                {
                    new_str += '?';
                }
            }
            textBox2.Text = new_str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string my_str = textBox10.Text;
            string new_str = "";
            for (int i = 0; i < my_str.Length; i++)
            {
                if (my_str[i] != '5')
                {
                    new_str += my_str[i];
                }
                else
                {
                    new_str += "пять";
                }
            }
            textBox2.Text = new_str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string my_str = textBox8.Text + ' ';
            string new_str = "";
            string to_del = textBox7.Text;
            for (int i = 0; i < my_str.Length - 1; i++)
            {
                if (my_str[i] == to_del[0] && my_str[i + 1] == to_del[1])
                {
                    new_str += "C#";
                    i++;
                }
                else
                {
                    new_str += my_str[i];
                }
            }
            textBox2.Text = new_str;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();   
            string my_str = textBox9.Text;
            int c = my_str[0];
            textBox2.Text = c.ToString();
            textBox2.Text = c.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string my_str = textBox12.Text + " ";
            int symb_count = 0;
            for (int i = 0; i < my_str.Length - 1; i++)
            {
                if (my_str[i] != ' ' && my_str[i + 1] == ' ')
                {
                    symb_count++;
                }
            }
            label1.Text = Convert.ToString(symb_count);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string my_str = textBox13.Text + " ";
            bool is_first = false;
            string str = "";
            for (int i = 0; i < my_str.Length - 1; i++)
            {
                if (my_str[i] != ' ' && my_str[i + 1] != ' ' && is_first != true)
                {
                    
                    str += my_str[i];
                }
                else { is_first = true; }
            }
            textBox2.Text = str;
        }
    }
}
