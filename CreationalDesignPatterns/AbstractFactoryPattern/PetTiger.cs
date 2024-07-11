using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Pet Tiger prefers staying in the jungle.\n\n");
        }
    }
}