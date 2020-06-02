using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctpoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox2.ScrollBars = ScrollBars.Vertical;
        }
        bool palindrom(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[str.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return false;
                    //break;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string my_text = textBox1.Text + " ";
            string str = "";
            int sum = 0;
            for (int i = 0; i < my_text.Length ; i++)
            {
                if (my_text[i] != ' ')
                {
                    str += my_text[i];
                }
                else
                {
                    if (palindrom(str))
                    {
                        //textBox2.Text += str + " - палиндром\r\n";
                        sum++;
                    }
                    str = "";
                }
            }
            textBox2.Text += "Палиндромов - " + sum;
            str = "";
            sum = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            /*string my_text = textBox1.Text + " ";
            string str = "";
            int sum = 0;
            List<string> words = new List<string>();
            for (int i = 0; i < my_text.Length; i++)
            {
                if (my_text[i] != ' ' && my_text[i] != '.')
                {
                    str += my_text[i];
                }
                else if (my_text[i] == '.')
                {
                    words.Add(str);
                    str = "";
                    sum++;
                }
                *//*if (my_text[i] != ' ' && my_text[i] != '.')
                {
                    str += my_text[i];
                    //sum++;
                }
                else
                if (my_text[i] == '.')
                {
                    words.Add(str);
                    sum++;
                    str = "";
                }
                else
                if (my_text[i] == ' ')
                {
                    words.Add(str);
                    str = "";
                }*/
            /*}
            foreach (string i in words)
            {
                textBox2.Text += i + "\r\n";
            }
            textBox2.Text += sum;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string my_text = textBox1.Text + " ";
            string str = "";
            List<string> words = new List<string>();
            for (int i = 0; i < my_text.Length; i++)
            {
                if (my_text[i] != ' ')
                {
                    str += my_text[i];
                }
                else
                {
                    words.Add(str);
                    str = "";
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0) // четное в привычном человку виде
                {
                    textBox2.Text += "ПЯВУ ";
                }
                else
                {
                    textBox2.Text += words[i] + " ";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*textBox2.Clear();
            string my_text = textBox1.Text + " ";
            string str = "";
            int sum = 0;
            int max_len = 0;
            int max_index = 0;
            List<string> words = new List<string>();
            List<string> sentences = new List<string>();
            for (int i = 0; i < my_text.Length; i++)
            {
                if (my_text[i] != ' ')
                {
                    str += my_text[i];
                }
                else if (my_text[i] == ' ')
                {
                    sentences.Add(str);
                    str = "";
                }
            }
            str = "";
            for (int i = 0; i < sentences.Count; i++)
            {
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if (sentences[i][j] != '.' && sentences[i][j] != ' ')
                    {
                        str += sentences[i][j];
                    }
                    else if (sentences[i][j] == '.')
                    {
                        words.Add(str);
                        str = "";
                    }
                    *//*else if (sentences[i][j] == ' ' && str == "")
                    {
                        
                    }*//*
                }
            }
            foreach (string i in sentences)
            {
                textBox2.Text += i + "\r\n";
            }
            textBox2.Text += "============\r\n";
            foreach (string i in words)
            {
                //if ()
                textBox2.Text += i + "\r\n";
            }*/
        }
    }
}
