using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacadePattern.Interfaces;

namespace FacadePattern.Models
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("\t SubSystem Order : PlaceOrderDetails");
            return 10;
        }
    }
}