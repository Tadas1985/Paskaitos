using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Models
{
    public class BooksRepository
    {

        public List<Book> BookList { get; }
        public List<string> bookList { get; private set; }

        public BooksRepository(List<Book> bookList) 
        {
            BookList = bookList;    
        }

        public BooksRepository()
        {
        }

        public void SaveBookTitle(Book book)
        {
            FileWriteService service = new FileWriteService();
            service.AppendText(book.Title);
        }
        public void SaveBookAuthor(Book book)
        {
            FileWriteService service = new FileWriteService();
            service.AppendText(book.Author);
        }
        public void SaveBookYear(Book book)
        {
            FileWriteService service = new FileWriteService();
            service.AppendText(book.BookReleaseDate.ToString());
        }

        // Paklausk kaip padaryti funkcija kuri priima 2 stringus, 1 integeri ir grazina lista!!!
        //public List<string> SaveBookDetailsToList(Book book, Book book1, Book book2)
        //{
        //    List<string> bookList = new List<string>();
        //    return bookList.Add);
        //}
    }



}

