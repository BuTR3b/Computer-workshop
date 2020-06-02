using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Book
    {
        public string Author;
        public string Title;
        public string Genre;
        public int Year;

        public string get_author()
        {
            return this.Author;
        }

        public Book(string a, string b, string c, int n)
        {
            Author = a;
            Title = b;
            Genre = c;
            Year = n;
        }

        public string ToString()
        {
            return "Автор: " + this.Author + "\r\nНазвание: " + this.Title + "\r\nЖанр: " + this.Genre + "\r\nГод: " + this.Year + "\r\n";
        }

        public string to_write()
        {
            return this.Author + "\r\n" + this.Title + "\r\n" + this.Genre + "\r\n" + this.Year + "\r\n";
        }
    }
}
