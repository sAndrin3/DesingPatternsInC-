using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern.Solid
{
    public interface IReceiptSender
    {
        void SendReceipt();
    }
    public class EmailReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("Email sent");
        }
    }
    public class TextReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("Text Sent");
        }
    }
}