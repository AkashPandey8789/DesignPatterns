public interface IPayment
{
    void BillPayment();
}

public class CreditCard : IPayment
{
    public void BillPayment()
    {
        Console.WriteLine("Payment done via credit card");
    }
}

public class DebitCard : IPayment
{
    public void BillPayment()
    {
        Console.WriteLine("Payment done via debit card");
    }
}

public class Cash : IPayment
{
    public void BillPayment()
    {
        Console.WriteLine("Payment done in cash");
    }
}

public class Payment
{
    private IPayment _payment;

    public void SelectPaymentMethod(IPayment payment)
    {
        _payment = payment;
    }

    public void CompletePayment()
    {
        _payment.BillPayment();
    }

}