using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public abstract class Animal
    {
        //declare parent class methods default
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        //declare abstract methods to be implemented by child classes
        public abstract void Move();
        public abstract void Speak();

        //declare virtual methods that can be overridden by child classes
        public virtual void Name()
        {
            Console.WriteLine("Default: Sherman");
        }

        public virtual void Age()
        {
            Console.WriteLine("\tOLD ass ANIMAL!");
        }
    }
}
