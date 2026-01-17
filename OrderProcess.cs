public class Order
{
    public bool ProcessDiscount()
    {
        Console.WriteLine("Processing discount for the order.");
        return true;
    }
    public bool ProcessPayment()
    {
        Console.WriteLine("Processing payment for the order.");
        return true;
    }

    public bool ShipOrder()
    {
        Console.WriteLine("Shipping the order.");
        return true;
    }
}

public abstract class OrderHandler
{
    protected OrderHandler nextHandler;

    public void SetNextHandler(OrderHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void Process(Order order);
}

public class DiscountHandler : OrderHandler
{
    public override void Process(Order order)
    {
        if (order.ProcessDiscount())
        {
            Console.WriteLine("Processed discount!!");
            if (nextHandler != null) nextHandler.Process(order);
        }
        else
        {
            Console.WriteLine("Failed to process discount.");
        }
    }
}

public class PaymentHandler : OrderHandler
{
    public override void Process(Order order)
    {
        if (order.ProcessPayment())
        {
            Console.WriteLine("Payment processed!!");
            if (nextHandler != null) nextHandler.Process(order);
        }
        else
        {
            Console.WriteLine("Failed to process payment.");
        }
    }
}

public class ShippmentHandler : OrderHandler
{
    public override void Process(Order order)
    {
        if (order.ShipOrder())
        {
            Console.WriteLine("Order Shipped!!");
            if (nextHandler != null) nextHandler.Process(order);
        }
        else
        {
            Console.WriteLine("Order shipping failed.");
        }
    }
}