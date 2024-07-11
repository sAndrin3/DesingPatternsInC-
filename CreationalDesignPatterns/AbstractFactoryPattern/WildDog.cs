using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class WildDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Wild Dog says: Wroof-wroof.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Wild Dog lives in the woods.\n\n");
        }
    }
}