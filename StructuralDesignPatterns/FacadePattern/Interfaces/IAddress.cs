using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacadePattern.Models;

namespace FacadePattern.Interfaces
{
    public interface IAddress
    {
        Address GetAddressDetails(int userID);
    }
}