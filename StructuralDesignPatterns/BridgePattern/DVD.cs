using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class DVD : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nDVD is functioning at : ");
            state.MoveState();
        }
    }
}