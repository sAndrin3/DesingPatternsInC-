using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public sealed class Hyundai : ICar
    {
        public  string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 5000000;
        }
    }
}