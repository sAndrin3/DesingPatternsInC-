using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface ICar
    {
        string Make {get; }
        double GetPrice();
    }
}