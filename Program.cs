// See https://aka.ms/new-console-template for more information
Order order = new Order();

DiscountHandler discountHandler = new DiscountHandler();
PaymentHandler paymentHandler = new PaymentHandler();
ShippmentHandler shippmentHandler = new ShippmentHandler();

discountHandler.SetNextHandler(paymentHandler);
paymentHandler.SetNextHandler(shippmentHandler);

discountHandler.Process(order);

Console.WriteLine("Order processing completed.");

//Mediator pattern

Passenger p = new Passenger("Radha", "Mathura", new TaxiDispatcher());

p.RideRequest();

//Strategy Pattern

IPayment payment = new Cash();

Payment paymentContext = new Payment();

paymentContext.SelectPaymentMethod(payment);
paymentContext.CompletePayment();