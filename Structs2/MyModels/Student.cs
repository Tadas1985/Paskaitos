using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs2
{
    public struct Student
    {
        public List<int> semester1;
        public List<int> semester2;
        public List<int> semester3;

        public Student(List<int> semester1, List<int> semester2, List<int> semester3)
        {
            this.semester1 = semester1;
            this.semester2 = semester2;
            this.semester3 = semester3;
        }

        public int SemesterAverage(List<int> sum)
        {
            int i = 0;
            foreach (var item in sum)
            {
                i += item;
            }
            return i / sum.Count;
        }
        public int YearAverage(List<int> semester1, List<int> semester2, List<int> semester3)
        {
            int yearAverage = (SemesterAverage(semester1) + SemesterAverage(semester2) + SemesterAverage(semester3))/3;
            return yearAverage;
        }
    }
    
}
