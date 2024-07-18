using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.ShoppingFacade
{
    public interface IUserOrder
    {
        int AddToCart(int itemId, int qty);
        int PlaceOrder(int cartID, int userID);
    }
}