using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            return (Ford)this.MemberwiseClone();
        }
    }
}