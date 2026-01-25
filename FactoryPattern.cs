public abstract class CreditCards
{
    public abstract void GetType();

    public abstract void GetLimit();

    public abstract void GetAnnualCharge();
}

public class Titanium : CreditCards
{
    public override void GetType()
    {
        Console.WriteLine("Titanium card");
    }

    public override void GetLimit()
    {
        Console.WriteLine("Your limit is Rs. 5000000");
    }
    public override void GetAnnualCharge()
    {
        Console.WriteLine("Annual Charges - Rs. 1000");
    }

}

public class CashBack : CreditCards
{
    public override void GetType()
    {
        Console.WriteLine("CashBack card");
    }

    public override void GetLimit()
    {
        Console.WriteLine("Your limit is Rs. 10000000");
    }
    public override void GetAnnualCharge()
    {
        Console.WriteLine("Annual Charges - Rs. 2000");
    }
}

public abstract class CreditCardFactory
{
    public abstract CreditCards MakeCreditCard();

    public CreditCards CreateCreaditCard()
    {
        return this.MakeCreditCard();
    }
}


public class TitaniumFactory : CreditCardFactory
{
    public override CreditCards MakeCreditCard()
    {
        return new Titanium();
    }
}

public class CashBackFactory : CreditCardFactory
{
    public override CreditCards MakeCreditCard()
    {
        return new CashBack();
    }
}

