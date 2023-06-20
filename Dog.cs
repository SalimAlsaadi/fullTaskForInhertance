using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Dog : Animals
    {

        public override void makeNoice()
        {
            Console.WriteLine("Dog sound Woof");
        }

        public override void eat()
        {
            Console.WriteLine("I eat Dog Food");
        }

    }
}
