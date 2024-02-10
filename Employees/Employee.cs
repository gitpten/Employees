using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public double Rank { get; set; }

        public virtual double GetSalary(int days)
        {
            return days * Rank;
        }
    }
}
