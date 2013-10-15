using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Cat : Animal 
    {
        //override abstract classes here
        public override void Move()
        {
            Console.WriteLine("Prancing CAT");
        }

        public override void Speak()
        {
            Console.WriteLine("Meoooow!");
        }

        //override virtual classes here
        public override void Name()
        {
            Console.WriteLine("CAT name: Shrek.");
        }

        public override void Age()
        {
            Console.WriteLine("I'm a kitten! CAT");
        }
    }
}
