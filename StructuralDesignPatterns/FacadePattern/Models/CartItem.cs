using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class CartItem
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double TaxPercentage { get; set; }
        public double Cost { get; set; }
        public double Price {get; set; }
    }
}