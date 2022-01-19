using System;
using System.Collections.Generic;
using Structs2;

namespace Structs2
{
    public struct Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.semester1 = new List<int>() {3, 10, 3};
            student.semester2 = new List<int>() {7, 6, 6};
            student.semester3 = new List<int>() {2,1,5};



            Console.WriteLine(student.SemesterAverage(student.semester1));
            Console.WriteLine(student.YearAverage(student.semester1, student.semester2, student.semester3));
            //-----------------------------------------------------------
            
        }

        
    }
}
