using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1.OOPTest
{
    internal class Cat : Animal
    {

        public string? Name { get; set; }

        public void voice()
        {
            Console.WriteLine("Meoow, meeow");
        }

        public override void animalSound()
        {
            Console.WriteLine("Meoow 2 lapar");
        }

        public string testName(String name) {
            return "My name " + name;
        }
    }
}
