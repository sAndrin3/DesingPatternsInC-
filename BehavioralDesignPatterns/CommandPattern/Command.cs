using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IMessage { }
    public interface ICommand
    {
        bool Execute(IMessage message);
        bool Rollback(IMessage message);
    }

    public class orderCommand : ICommand
    {
        private readonly IProxy<Order> orderProxy;

        public orderCommand(IProxy<Order> orderProxy)
        {
            this.orderProxy = orderProxy;
        }

        public bool Execute(IMessage message)
        {
            return orderProxy.Create((Order)message);
        }

        public bool Rollback(IMessage message)
        {
            return orderProxy.Delete((Order)message);
        }
    }

    public class inventoryCommand : ICommand
    {
        private readonly IProxy<Inventory> inventoryProxy;

        public inventoryCommand(IProxy<Inventory> inventoryProxy)
        {
            this.inventoryProxy = inventoryProxy;
        }

        public bool Execute(IMessage message)
        {
            return inventoryProxy.Create((Inventory)message);
        }

        public bool Rollback(IMessage message)
        {
            return inventoryProxy.Delete((Inventory)message);
        }
    }
}