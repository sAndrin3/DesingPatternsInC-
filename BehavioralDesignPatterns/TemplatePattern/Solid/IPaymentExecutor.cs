using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern.Solid
{
    public interface IPaymentExecutor
    {
        void ExecutePayment();
    }
    public class PaymentExecutor : IPaymentExecutor
    {
        public void ExecutePayment()
        {
            Console.WriteLine("Payment executed");
        }
    }
}