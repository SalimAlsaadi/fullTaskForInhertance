using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Manager : Employee
    {
        public int numberOFEmplokyee;

        public Manager(string name, string salary, string department, int numberOFEmplokyee) : base(name, salary, department)
        {
            this.numberOFEmplokyee = numberOFEmplokyee;
        }

        public override void calculatePay()
        {
            Console.WriteLine("salary manager is 1500 ");
        }
    }
}
