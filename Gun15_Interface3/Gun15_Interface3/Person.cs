using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface3
{
    public class Person : IEntity
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
