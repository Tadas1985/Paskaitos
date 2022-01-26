using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FileWriteServiceStrorage
    {
        
        private readonly string _path = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\Paskaitos\PASKAITOS\OOP-2\Files\Books.txt";
        public void AppendText(string text)
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine(text);
            }
        }

        public void WriteAllText(string[] lines)
        {
            File.WriteAllLines(_path, lines);
        }

        public List<string> GetAllLines()
        {
            var lines = File.ReadAllLines(_path);
            return lines.ToList();
        }
    }
}
