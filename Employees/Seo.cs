using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Seo : Employee
    {
        public double SeoBonus { get; set; }
        public List<Manager> Managers { get; set; } = new List<Manager>();
        public override double GetSalary(int Days)
        {
            return SeoBonus * Managers.Sum(m => m.VolumeSales);
        }
    }
}
