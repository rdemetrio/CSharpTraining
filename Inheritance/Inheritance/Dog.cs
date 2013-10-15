using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Dog : Animal
    {
        //override abstract classes here
        public override void Move()
        {
            Console.WriteLine("Running DOG");
        }

        public override void Speak()
        {
            Console.WriteLine("Woof, Woof!");
        }

        //override virtual classes here
        public override void Name()
        {
            Console.WriteLine("Dog name Fido.");
        }

        public override void Age()
        {
            Console.WriteLine("I'm a Puppy! DOG");
        }
    }
}
