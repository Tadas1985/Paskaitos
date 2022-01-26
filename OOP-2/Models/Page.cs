using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Page
    {
        public string Content { get; set; }
        public int PageNumber { get; set; }

        public Page(string content)
        {
            Content = content;
        }

        public Page(string content, int pageNumber)
        {
            Content = content;
            PageNumber = pageNumber;
        }

        public Page()
        {
        }
    }
}
