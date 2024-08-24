using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_Abstraction
{
    public class Student : Person
    {
        public string StudentNumber { get; set; }

        public override void AddToDb()
        {

            base.AddToDb();

            Console.WriteLine(StudentNumber + " değeri eklendi  ");
        }

    }
}
