using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Bmw : BasicCar
    {
        public Bmw(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            return(Bmw)this.MemberwiseClone();
        }
    }
}