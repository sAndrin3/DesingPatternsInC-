using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class WildTiger : ITiger
    {
         public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Haleeem.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Wild Tiger lives in the forest.\n\n");
        }
    }
}