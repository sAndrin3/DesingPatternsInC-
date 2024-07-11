using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PetDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Pet Dog says: Woof-Woof.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Pet Dog prefers to stay at home.\n\n");
        }
    }
}