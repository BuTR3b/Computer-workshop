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

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        string[] letters2 = new string[] { "а", "о", "у", "э", "ы", "я", "е", "ё", "ю", "и" };
        char[] letters = new char[] { 'а', 'о', 'у', 'э', 'ы', 'я', 'е', 'ё', 'ю', 'и' };

        public Form2()
        {
            InitializeComponent();
            int[] count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string path = @"C:\КП";
            string path_file_words = @"C:\КП\words.txt";
            string path_file_letters = @"C:\КП\letters.txt";
            //List<string> words = new List<string>();
            string text;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists || dirInfo.GetFiles().Length == 0)
            {
                MessageBox.Show("Нет данных.");
            }
            else if (dirInfo.Exists && dirInfo.GetFiles().Length == 1)
            {
                StreamReader file = new StreamReader(path_file_words);
                text = file.ReadToEnd();
                file.Close();
                string[] words = text.Split(' ');
                for (int i = 0; i < letters.Length; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j][0] == letters[i])
                        {
                            count[i]++;
                        }
                    }
                }
                StreamWriter file1 = new StreamWriter(path_file_letters);
                for (int i = 0; i < letters.Length; i++)
                {
                    file1.Write(letters[i]);
                    file1.Write(" ");
                    file1.Write(count[i]);
                    file1.Write("\r\n");
                }
                file1.Close();
                chart1.Series["Series1"].Points.DataBindXY(letters2, count);
            }
            
            /*
            List<string> myvar = new List<string>();
            int k = 0;
            for (int i = 0; i < genres.Count; i++)
            {
                for (int j = i; j < genres.Count; j++)
                {
                    if (genres[i] == genres[j])
                    {
                        k++;
                    }
                }
                myvar.Add(genres[i]);
                count.Add(k);
                k = 0;
            }
            IEnumerable<string> uniq = genres.Distinct();
            int iter = 0;
            foreach (var i in uniq)
            {
                chart1.Series["Жанры"].Points.AddXY(i, count[iter]);
                iter++;
            }*/
        }
    }
}
