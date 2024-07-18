using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car) : base(car){ }
        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}