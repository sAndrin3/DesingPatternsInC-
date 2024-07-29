using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IOrchestrator
    {
        bool CreateOrder(Order order);
    }
}