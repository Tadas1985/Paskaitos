using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct BibliotekosKnyga
    {
        public BibliotekosKnyga(int iD, string name, string readersName, DateTime takenTime)
        {
            ID = iD;
            Name = name;
            ReadersName = readersName;
            TakenTime = takenTime;
        }

        public int ID { get;  }
        public string Name { get;  }
        public string ReadersName { get;  }
        public DateTime TakenTime { get; }

        //int daysAtReader;
        public int DaysBookAtREaders(DateTime taken)
        {
            return  Convert.ToInt16( DateTime.Now - taken);
        }

    }
}
