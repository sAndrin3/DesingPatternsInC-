using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Interfaces
{
    public interface ITax
    {
        double GetTaxByState(string state);
        void ApplyTax(int cartID, double taxPercentage);
    }
}