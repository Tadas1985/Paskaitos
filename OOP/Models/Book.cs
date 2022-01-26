using System;

namespace Models
{
    public class Book
    {
        // Konstruktorius
        public Book(string name, string author, int year, int bookAmount)
        {
            Name = name;
            Author = author;
            Year = year;
            BookAmount = bookAmount;
        }

        // Parametrai
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int BookAmount { get; set; }

        // Tuscias konstruktorius
        public Book()
        {
            
        }
    }
}
