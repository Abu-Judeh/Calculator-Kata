namespace Calculator_Kata;

public class UniversalDiscount:Discount
{
    public decimal Percentage { get; set; }

    public UniversalDiscount(decimal percentage)
    {
        Percentage = percentage;
    }

    public override decimal GetDiscountAmount(decimal originalPrice)
    {
        return Math.Round(originalPrice * (Percentage / 100),4);
    }
}