using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Magazine
    {
        public Magazine(Guid id, string name)
        {
            Id = id;
            Name = name;     
            Pages = new List<Page>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set; }
    }
}
