using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FileWriteService
    {
        private readonly string path = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\Paskaitos\PASKAITOS\OOP-2\Files\Books.txt";

        public void AppendText(string text)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);
            }
        }

        public void WriteAllText(string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        public List<string> GetAllLines()
        {
            var lines = File.ReadAllLines(path);
            return lines.ToList();
        }
        public void SaveBook(Book book)
        {
            FileWriteService service = new FileWriteService();  
            service.AppendText(book.Title);
        }

        public void AppendTexInSameLine(Book title, Book author, Book yearOfRelease)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                
            }
        }
    }
}
