using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
           Console.WriteLine("Dog says: Woof-Woof...");
        }
        public void Action()
        {
            Console.WriteLine("Dog prefers barking...");
        }
    }
}