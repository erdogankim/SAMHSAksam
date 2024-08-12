using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_OOP_Inheritance
{
    public class Student : Person
    {
        static Student()
        {
            Console.WriteLine("Student classı yaratıldı");
        }

        public Student()
        {
            Console.WriteLine("Student nesnesi yaratıldı");
        }

        public int StudentId { get; set; }
    }
}
