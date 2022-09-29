/*
   Bir nesne gelişime AÇIK değişime KAPALI olmalı.


 */

public class CustomerInfo
{
    public int RegisteredYear { get; set; }

    public virtual decimal GetDiscountForRegisteredYear(decimal price)
    {
        if (DateTime.Now.Year - RegisteredYear < 2)
        {
            return price * (1 - 0.05m);
        }
        return price;
    }
}
public class Plus5Year : CustomerInfo
{
    public override decimal GetDiscountForRegisteredYear(decimal price)
    {
        return base.GetDiscountForRegisteredYear(price);
    }
}


public class Customer
{
    public CustomerInfo CustomerInfo { get; set; }
}

public class Order
{
    public Customer Customer { get; set; }
    public decimal GetDiscountedPrice(decimal price)
    {
        //Eğer 1 yılsa %5
        //Eğer 3       %10
        //     5       %15
        return Customer.CustomerInfo.GetDiscountForRegisteredYear(price);
    }
}