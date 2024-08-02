using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface INotificationSender
    {
        void Send(string message);
        void Accept(IVisitor visitor);
    }
}