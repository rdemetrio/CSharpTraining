using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog class
            Dog d = new Dog();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Cow());

            foreach (Animal ani in animals)
            {
                ani.Name();
                ani.Age();
                ani.Speak();
                ani.Move();

                d.Eat();
                d.Sleep();
            }
            
            Console.ReadKey();
        }
    }
}
