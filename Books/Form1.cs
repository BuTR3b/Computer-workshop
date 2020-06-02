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

namespace Books
{
    public partial class Form1 : Form
    {
        List<string[]> books_list = new List<string[]>();
        List<Book> new_bokk_list = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            textBoxShow.ScrollBars = ScrollBars.Vertical;
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] node = new string[4];
            if (textBoxAuthor.Text != "" && textBoxTitle.Text != "" && textBoxGenre.Text != "" && textBoxYear.Text != "")
            {
                node[0] = textBoxAuthor.Text;
                node[1] = textBoxTitle.Text;
                node[2] = textBoxGenre.Text;
                node[3] = textBoxYear.Text;
                Book book = new Book(node[0], node[1], node[2], Convert.ToInt32(node[3]));
                //books_list.Add(node);
                new_bokk_list.Add(book);
                //Array.Clear(node, 0, 4);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAuthor.Clear();
            textBoxGenre.Clear();
            textBoxTitle.Clear();
            textBoxYear.Clear();
            //textBoxShow.Clear();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxShow.Clear();
            string path = @"C:\Books_Library";
            string path_file = @"C:\Books_Library\lib.txt";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists || dirInfo.GetFiles().Length == 0)
            {
                MessageBox.Show("Нет такого файла или каталога.");
            }
            else if (dirInfo.Exists && dirInfo.GetFiles().Length == 1)
            {
                StreamReader file = new StreamReader(path_file);
                string text_info;
                text_info = file.ReadToEnd();
                file.Close();
                string[] words = text_info.Split('\n');
                for (int i = 0; i < words.Length - 1; i+=4)
                {
                    Book book = new Book(words[i], words[i + 1], words[i + 2], Convert.ToInt32(words[i + 3]));
                    textBoxShow.Text += book.ToString() + "\r\n";
                }
            }
        }

        private void buttonFindGenre_Click(object sender, EventArgs e)
        {
            textBoxShow.Clear();
            string genre = textBoxFindGenre.Text + "\r";
            if (genre.Length > 0)
            {
                string path = @"C:\Books_Library";
                string path_file = @"C:\Books_Library\lib.txt";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists || dirInfo.GetFiles().Length == 0)
                {
                    MessageBox.Show("Нет такого файла или каталога.");
                }
                else if (dirInfo.Exists && dirInfo.GetFiles().Length == 1)
                {
                    StreamReader file = new StreamReader(path_file);
                    string text_info;
                    text_info = file.ReadToEnd();
                    file.Close();
                    string[] words = text_info.Split('\n');
                    for (int i = 2; i < words.Length - 1; i += 4)
                    {
                        if (genre == words[i])
                        {
                            Book book = new Book(words[i - 2], words[i - 1], words[i], Convert.ToInt32(words[i + 1]));
                            textBoxShow.Text += book.ToString() + "\r\n";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска.");
            }
        }

        private void buttonFIndAuthor_Click(object sender, EventArgs e)
        {
            textBoxShow.Clear();
            string author = textBoxFindAuthor.Text + "\r";
            if (author.Length > 0)
            {
                string path = @"C:\Books_Library";
                string path_file = @"C:\Books_Library\lib.txt";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists || dirInfo.GetFiles().Length == 0)
                {
                    MessageBox.Show("Нет такого файла или каталога.");
                }
                else if (dirInfo.Exists && dirInfo.GetFiles().Length == 1)
                {
                    StreamReader file = new StreamReader(path_file);
                    string text_info;
                    text_info = file.ReadToEnd();
                    file.Close();
                    string[] words = text_info.Split('\n');
                    for (int i = 0; i < words.Length - 1; i += 4)
                    {
                        if (author == words[i])
                        {
                            Book book = new Book(words[i], words[i + 1], words[i + 2], Convert.ToInt32(words[i + 3]));
                            //textBoxShow.Text += words[i] + words[i + 1] + words[i + 2] + Convert.ToInt32(words[i + 3]);
                            //textBoxShow.Text += words[i];
                            textBoxShow.Text += book.ToString() + "\r\n";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Books_Library";
            string path_file = @"C:\Books_Library\lib.txt";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists || dirInfo.GetFiles().Length == 0)
            {
                MessageBox.Show("Нет такого файла или каталога.");
            }
            else if (dirInfo.Exists && dirInfo.GetFiles().Length == 1)
            {
                StreamReader file = new StreamReader(path_file);
                string text_info;
                text_info = file.ReadToEnd();
                file.Close();
                string[] words = text_info.Split('\n');
                for (int i = 3; i < words.Length - 1; i += 4)
                {
                    if (Convert.ToInt32(words[i]) < 2000)
                    {
                        Book book = new Book(words[i - 3], words[i - 2], words[i - 1], Convert.ToInt32(words[i]));
                        //textBoxShow.Text += words[i] + words[i + 1] + words[i + 2] + Convert.ToInt32(words[i + 3]);
                        //textBoxShow.Text += words[i];
                        textBoxShow.Text += book.ToString() + "\r\n";
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (new_bokk_list.Count > 0)
            {
                if (new_bokk_list.Count > 1)
                {
                    Book tmp;
                    for (int i = 0; i < new_bokk_list.Count; i++)
                    {
                        for (int j = i; j < new_bokk_list.Count; j++)
                        {
                            if (new_bokk_list[i].Year > new_bokk_list[j].Year)
                            {
                                tmp = new_bokk_list[i];
                                new_bokk_list[i] = new_bokk_list[j];
                                new_bokk_list[j] = tmp;
                            }
                        }
                    }
                }
                string path = @"C:\Books_Library";
                string path_file = @"C:\Books_Library\lib.txt";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                    StreamWriter file = new StreamWriter(path_file, true);
                    for (int i = 0; i < new_bokk_list.Count; i++)
                    {
                        file.Write(new_bokk_list[i].to_write());
                    }
                    file.Close();
                }
                else
                {
                    StreamWriter file = new StreamWriter(path_file, true);
                    for (int i = 0; i < new_bokk_list.Count; i++)
                    {
                        file.Write(new_bokk_list[i].to_write());
                    }
                    file.Close();
                }
                new_bokk_list.Clear();
            }
            else
            {
                MessageBox.Show("Список пуст.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
