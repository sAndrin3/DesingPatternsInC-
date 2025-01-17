using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class Product
    {
        public int ProductID{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public int LockedQty { get; set; }
    }
}