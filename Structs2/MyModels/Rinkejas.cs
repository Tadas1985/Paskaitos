using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs2
{
    public struct Rinkejas
    {
        public int ID { get; set; }
        public bool Voted { get; set; }

        public Rinkejas(int iD, bool voted)
        {
            ID = iD;
            Voted = voted;
        }

    }
}
