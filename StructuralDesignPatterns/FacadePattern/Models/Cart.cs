using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class Cart
    {
        public int CartID {get; set; }
        public int userID { get; set; }
        public IEnumerable<CartItem> ShoppingCart { get; set; }
    }
}