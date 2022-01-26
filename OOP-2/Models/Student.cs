using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student(int studentID, string name, string address)
        {
            StudentID = studentID;
            Name = name;
            Address = address;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Student information");
            Console.WriteLine($"StudentID: {StudentID}, Name: {Name}, Adress: {Address}");

        }

    }
}
