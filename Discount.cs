namespace Calculator_Kata;

public abstract class Discount
{
    public abstract decimal GetDiscountAmount(decimal originalPrice);
    
    public decimal GetCapDiscount(decimal price,decimal originalDiscount,decimal cap,bool isPercentageCap )
    {
        decimal capValue = isPercentageCap ? (price * cap / 100) : cap;

        return Math.Min(originalDiscount, capValue);

    }
    
}