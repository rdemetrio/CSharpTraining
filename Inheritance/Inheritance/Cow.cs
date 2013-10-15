using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Cow : Animal
    {
        //override abstract classes here
        public override void Move()
        {
            Console.WriteLine("Walking COW");
        }

        public override void Speak()
        {
            Console.WriteLine("MoOoOOo!");
        }

        //override virtual classes here
        public override void Name()
        {
            Console.WriteLine("COW name: Lester.");
        }

        public override void Age()
        {
            Console.WriteLine("A mature COW");
        }
    }
}
