using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Secretary : Employee
    {
        public int hourPerWeek;

        public Secretary(string name, string salary, string department, int hourPerWeek) : base(name, salary, department )
        {

        }

        public override void calculatePay()
        {
            Console.WriteLine("salary for Secretary is 325");
        }
    }
}
