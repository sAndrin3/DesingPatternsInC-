using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class InvoiceNotificationSender : INotificationSender
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