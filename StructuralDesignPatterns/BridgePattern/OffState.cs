using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Off State\n");
        }
    }
}