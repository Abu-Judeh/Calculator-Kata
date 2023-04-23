namespace Calculator_Kata;

public class AfterTaxDiscount:Discount
{
    public AfterTaxDiscount(decimal percentage) : base(percentage)
    {
    }

    public override decimal Apply(decimal price, decimal taxPercentage)
    {
        decimal priceWithTax = Math.Round(price * (1 + taxPercentage / 100), 2);
        return Math.Round(priceWithTax * (1 - Percentage / 100), 2);
    }
}