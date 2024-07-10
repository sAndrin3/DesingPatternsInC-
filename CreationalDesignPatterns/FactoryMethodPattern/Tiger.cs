using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum...");
        }
        public void Action()
        {
            Console.WriteLine("Tiger prefers hunting...");
        }
    }
}