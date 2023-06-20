using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Cat : Animals
    {

        public override void makeNoice()
        {
            Console.WriteLine("Cat sound Meow");
        }

        public override void eat()
        {
            Console.WriteLine("I eat cat Food");
        }
    }
}
