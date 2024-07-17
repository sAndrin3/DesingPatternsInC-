using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Television : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nTelevision is functioning at : ");
            state.MoveState();
        }
    }
}