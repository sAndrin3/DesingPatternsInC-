using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName {get; set; }
        public int Price{get; set; }
        public static int SetPrice()
        {
            int price = 0;
            Random r = new Random();
            int p = r.Next(20000, 50000);
            price = p;
            return price;
        }
        public abstract BasicCar Clone();
    }
}