using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_OOP_Inheritance
{
    public class Person
    {
        static Person()
        {
            Console.WriteLine("Person classı yaratıldı");
        }

        public Person()
        {
            Console.WriteLine("Person nesnesi yaratıldı.");

        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
