using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Manager : Employee
    {
        public double Bonus { get; set; }
        public double VolumeSales { get; set; }
        public override double GetSalary(int days)
        {
            return base.GetSalary(days) + Bonus * VolumeSales / 100;
        }
    }
}
