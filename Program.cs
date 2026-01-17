// See https://aka.ms/new-console-template for more information
Order order = new Order();

DiscountHandler discountHandler = new DiscountHandler();
PaymentHandler paymentHandler = new PaymentHandler();
ShippmentHandler shippmentHandler = new ShippmentHandler();

discountHandler.SetNextHandler(paymentHandler);
paymentHandler.SetNextHandler(shippmentHandler);

discountHandler.Process(order);

Console.WriteLine("Order processing completed.");