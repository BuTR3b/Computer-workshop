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
    public partial class Form2 : Form
    {
        List<string> genres = new List<string>();
        List<int> count = new List<int>();
        public Form2()
        {
            InitializeComponent();
            string path = @"C:\Books_Library";
            string path_file = @"C:\Books_Library\lib.txt";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists || dirInfo.GetFiles().Length == 0)
            {
                MessageBox.Show("Нет данных.");
            }
            else if (dirInfo.Exists && dirInfo.GetFiles().Length == 1)
            {
                StreamReader file = new StreamReader(path_file);
                string text_info;
                text_info = file.ReadToEnd();
                file.Close();
                string[] words = text_info.Split('\n');
                
                for (int i = 2; i < words.Length; i += 4)
                {
                    genres.Add(words[i]);
                }
            }
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
            }
        }
    }
}
