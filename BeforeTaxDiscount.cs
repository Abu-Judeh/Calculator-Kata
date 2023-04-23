namespace Calculator_Kata;

public class BeforeTaxDiscount:Discount
{
    public BeforeTaxDiscount(decimal percentage) : base(percentage){}

    public override decimal Apply(decimal price, decimal taxPercentage)
    {
        return Math.Round(price * (1 - Percentage / 100), 2);
    }
}