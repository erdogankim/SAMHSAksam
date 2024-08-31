using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface2
{
    public class SalaryOperation
    {
        public decimal CalculateSalary(IHasSalary hasSalary)
        {
            decimal baseSalary = hasSalary.GetSalary();
            decimal totalSalary = baseSalary * 1.15M;
            return totalSalary;
        }
    }
}
