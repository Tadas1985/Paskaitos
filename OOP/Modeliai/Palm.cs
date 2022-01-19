using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public struct Palm
    {
        public Palm(int ageMonths, int amountOfFruits)
        {
            AgeMonths = ageMonths;
            AmountOfFruits = amountOfFruits;
        }

        public int AgeMonths { get;  }
       
        public int AmountOfFruits { get; }

        public int AddOneMonthToAge(int ageMonths)
        {
            int frutAmount =0;
            ageMonths ++;
            for (int i = ageMonths; ageMonths <= 12; i++)
            {
                ageMonths ++;
                frutAmount += (12 - ageMonths) * 3;

            }

            return frutAmount;

            
        }
    }
}
