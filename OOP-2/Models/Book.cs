using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string title, string author, int bookReleaseDate)
        {
            Title = title;
            Author = author;
            BookReleaseDate = bookReleaseDate;
        }

        public string Title { get; }
        public string Author { get; }
        public int BookReleaseDate { get; }

        public Book(List<string> title, List<string> author, List<int> bookBeleaseDate)
        {
            Title = Title;
            Author = Author;
            BookReleaseDate = BookReleaseDate;
        }

        
    }
}
