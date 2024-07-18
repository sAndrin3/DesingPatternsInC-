using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacadePattern.Interfaces;

namespace FacadePattern
{
    public class AddressDetails: IAddress
    {
        public  Models.Address  GetAddressDetails(int userID)
        {
            Console.WriteLine("\t SubSystem Address : GetAddressDetails");
            return new Models.Address();
        }
        
    }
}
