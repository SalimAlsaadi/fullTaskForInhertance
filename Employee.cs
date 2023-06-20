using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Employee
    {
        public string? name;
        public string? salary;
        public string? department;

        public Employee(string name, string salary, string department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;

        }

        public virtual void calculatePay()
        {

        }
    }
}
