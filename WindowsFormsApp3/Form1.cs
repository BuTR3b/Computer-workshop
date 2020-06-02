using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string str = textBox1.Text + " ";
            string word = "";
            int min1 = 999;
            int min1_i = 0;
            int min2 = 998;
            int min2_i = 0;
            List<string> words = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    words.Add(word);
                    word = "";
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length < min1)
                {
                    min1 = words[i].Length;
                    min1_i = i;
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length < min2 && min2 >= min1 && min1_i != i)
                {
                    min2 = words[i].Length;
                    min2_i = i;
                }
            }
            textBox2.Text += words[min1_i] + " " + words[min2_i];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string str = textBox1.Text + " ";
            string word = "";
            List<string> words = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    words.Add(word);
                    word = "";
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                textBox2.Text += words[i][0] + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string str = textBox1.Text;
            string text = "";
            string symbols = "";
            string path = @"C:\КП";
            string path_file_text = @"C:\КП\text.txt";
            string path_file_symbols = @"C:\КП\symbols.txt";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                StreamWriter file1 = new StreamWriter(path_file_text, false);
                file1.Write(str);
                file1.Close();
            }
            else
            {
                StreamWriter file1 = new StreamWriter(path_file_text, false);
                file1.Write(str);
                file1.Close();
            }

            StreamReader file2 = new StreamReader(path_file_text);
            text = file2.ReadToEnd();
            file2.Close();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == ';' || text[i] == ':')
                {
                    symbols += text[i] + " ";
                }
            }
            StreamWriter file3 = new StreamWriter(path_file_symbols, false);
            file3.Write(symbols);
            file3.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string str = textBox1.Text;
            string text = "";
            string word = "";
            string path = @"C:\КП";
            string path_file_text1 = @"C:\КП\text1.txt";
            string path_file_text2 = @"C:\КП\text2.txt";
            List<string> words = new List<string>();
            List<List<string>> sentences = new List<List<string>>();
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                StreamWriter file1 = new StreamWriter(path_file_text1, false);
                file1.Write(str);
                file1.Close();
            }
            else
            {
                StreamWriter file1 = new StreamWriter(path_file_text1, false);
                file1.Write(str);
                file1.Close();
            }

            StreamReader file2 = new StreamReader(path_file_text1);
            text = file2.ReadToEnd();
            file2.Close();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != '.')
                {
                    word += text[i];
                }
                else if (text[i] == '.')
                {
                    //word += text[i];
                    words.Add(word);
                    sentences.Add(words);
                    word = "";
                    words = new List<string>();
                }
                else if (text[i] == ' ' && word != "")
                {
                    words.Add(word);
                    word = "";
                }
            }
            for (int i = 0; i < sentences.Count; i++)
            {
                textBox2.Text += sentences[i].Count + "\r\n";
            }
            //textBox2.Text += sentences[0].Count;
            StreamWriter file3 = new StreamWriter(path_file_text2, false);
            for (int i = 0; i < sentences.Count; i++)
            {
                if (sentences[i].Count != 2)
                {
                    for (int j = 0; j < sentences[i].Count; j++)
                    {
                        if (j < sentences[i].Count - 1)
                        {
                            file3.Write(sentences[i][j] + ' ');
                        }
                        else if (j == sentences[i].Count - 1)
                        {
                            file3.Write(sentences[i][j]);
                        }
                    }
                    file3.Write(". ");
                }
            }
            file3.Close();
        }
    }
}
