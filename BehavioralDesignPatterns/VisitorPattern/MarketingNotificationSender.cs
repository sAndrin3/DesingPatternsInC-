using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class MarketingNotificationSender : INotificationSender
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void Send(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }
}