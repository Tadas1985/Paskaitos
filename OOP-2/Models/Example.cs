using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Example
    {
        List<int> items = new List<int>();

        public List<int> AddItem( int x)
        {
            items.Add(x);
            return items;
        }
    }
}
