using TemplatePattern.Solid;

var itemValidator = new ItemValidator();
var paymentExecutor = new PaymentExecutor();

var emailReceiptSender = new EmailReceiptSender();
var textReceiptSender = new TextReceiptSender();

var cart = new Cart(itemValidator, paymentExecutor, emailReceiptSender);
cart.Checkout();

cart = new Cart(itemValidator, paymentExecutor, textReceiptSender);
cart.Checkout();