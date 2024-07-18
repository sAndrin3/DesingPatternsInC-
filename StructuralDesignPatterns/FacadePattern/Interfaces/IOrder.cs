using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Interfaces
{
    public interface IOrder
    {
        int PlaceOrderDetails(int cartID, int shippingAddressID);
    }
}