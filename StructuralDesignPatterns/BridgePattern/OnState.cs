using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("On State\n");
        }
    }
}