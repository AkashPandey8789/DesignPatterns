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

//Observer pattern

ISubject subject = new Subject();

Observer observer = new Observer(subject, "Ram");
Observer ob2 = new Observer(subject, "Sita");
observer.NotifyMe();
ob2.NotifyMe();

subject.NotifyObserver();

//Singleton

Parallel.Invoke(
    () => FirstCall(),
    () => SecondCall()
);

void FirstCall()
{
    Singleton singleton = Singleton.GetInstance();

    singleton.Print("Akash says hi!!");
}

void SecondCall()
{
    Singleton singleton2 = Singleton.GetInstance();
    singleton2.Print("Now bye");
}

//Factory - Method pattern

CreditCards card = new TitaniumFactory().CreateCreaditCard();

card.GetType();

CreditCards card2 = new CashBackFactory().CreateCreaditCard();
card2.GetType();



