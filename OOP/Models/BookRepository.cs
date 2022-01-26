using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BookRepository
    {
        FileWriteServiceStrorage Writer = new FileWriteServiceStrorage();
        BookServiceReader ReaderWriter = new BookServiceReader();
        public List<string> ListBooks { get; set; }


        // Susikuriam konstruktoriu
        public BookRepository()
        {
            ListBooks = new List<string>();
        }
        public void WriteBookToFile(Book book, List<Book> listBooks) // ListBook
        {
            bool isNotList = true;
            for (int i = 0; i < listBooks.Count; i++)
            {
                Book tempBook = listBooks[i];
                if (tempBook.Name == book.Name)
                {
                    listBooks[i].BookAmount++;
                    isNotList = false;
                }
            }
            if (isNotList)
            {
                string saveBook = $"{book.Name}, {book.Author}, {book.Year}, {book.BookAmount}";
                Writer.AppendText(saveBook);
                listBooks.Add(book);
            }
        }
        public void WriteAllBookToFile(List<Book> book)
        {
            List<string> templist = new List<string>();
            foreach (Book record in book)
            {
                templist.Add($"{record.Name}, {record.Author}, {record.Year}, {record.BookAmount}");
            }
            Writer.WriteAllText(templist.ToArray());
        }
        public List<Book> REadAllBooksFromFile()
        {
            ListBooks.Clear();
            var listBooks = new List<Book>();
            List<string> allLinesFromFile = Writer.GetAllLines();
            for (int i = 0; i < allLinesFromFile.Count; i++)
            {
                var book = new Book();
                string[] temp = allLinesFromFile[i].Split(",");
                book.Name = temp[0];
                book.Author = temp[1];
                book.Year = Convert.ToInt32(temp[2]);
                book.BookAmount = Convert.ToInt32(temp[3]);
                listBooks.Add(book);
            }
            return listBooks;
        }
    }
}
