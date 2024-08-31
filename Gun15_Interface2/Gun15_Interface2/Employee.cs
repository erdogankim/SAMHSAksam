using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface2
{
    public class Employee : Person, IHasSalary
    {
        public string Branch { get; set; }
        public string PersonalNumber { get; set; }

        public decimal GetSalary()
        {
            return 17002;
        }
    }
}
