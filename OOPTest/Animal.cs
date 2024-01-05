using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1.OOPTest
{
	abstract class Animal
	{
		
		public void sleep()
		{
            Console.WriteLine("Zzzzz.");
        }

		public virtual void animalSound()
		{
			Console.WriteLine("Make sound animal");
		}
	}
}
