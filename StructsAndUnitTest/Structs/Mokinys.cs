using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Mokinys
    {
        public Mokinys(string name, string lastName, DateTime kursoPradzia, DateTime kursoPabaiga)
        {
            Name = name;
            LastName = lastName;
            this.kursoPradzia = kursoPradzia;
            this.kursoPabaiga = kursoPabaiga;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime kursoPradzia { get; set; }
        public DateTime kursoPabaiga { get; set; }
    }
}
