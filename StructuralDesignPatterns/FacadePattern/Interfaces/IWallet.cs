using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Interfaces
{
    public interface IWallet
    {
        double GetUserBalance(int userID);
    }
}