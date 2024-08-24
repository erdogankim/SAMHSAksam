using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_Abstraction
{
    public class Person
    {
        public string TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void AddToDb()
        {
            Console.WriteLine(TCKN + " " + Name + " " + Surname + " bilgileri db ye eklendi.");
        }
    }
}