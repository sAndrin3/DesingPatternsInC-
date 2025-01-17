using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern.Solid
{
    internal class Cart
    {
        private readonly IItemValidator itemValidator;
        private readonly IPaymentExecutor paymentExecutor;
        private readonly IReceiptSender receiptSender;

        public Cart(IItemValidator itemValidator, IPaymentExecutor paymentExecutor, IReceiptSender receiptSender)
        {
            this.itemValidator = itemValidator;
            this.paymentExecutor = paymentExecutor;
            this.receiptSender = receiptSender;
        }
        public void Checkout()
        {
            itemValidator.ValidateItem();
            paymentExecutor.ExecutePayment();
            receiptSender.SendReceipt();
        }
    }
}