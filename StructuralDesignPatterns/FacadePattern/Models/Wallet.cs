using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacadePattern.Interfaces;

namespace FacadePattern.Models
{
    public class Wallet: IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t SubSystem Wallet : GetUserBalance");
            return 100;
        }
    }
}