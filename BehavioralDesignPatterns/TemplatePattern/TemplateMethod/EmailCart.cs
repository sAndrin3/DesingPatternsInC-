using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern.TemplateMethod
{
    internal class EmailCart : Cart
    {
        protected override void SendReceipt()
        {
            Console.WriteLine("Email Sent");
        }
    }
    internal class TextCart : Cart
    {
        protected override void SendReceipt()
        {
            Console.WriteLine("Text Sent");
        }
    }
}