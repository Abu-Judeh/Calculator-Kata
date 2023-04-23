namespace Calculator_Kata;

public class UpcDiscount : Discount
{
    public int Upc { get; set; }
    public decimal Percentage { get; set; }

    public UpcDiscount(int upc, decimal percentage)
    {
        Upc = upc;
        Percentage = percentage;
    }

    public override decimal GetDiscountAmount(decimal originalPrice)
    {
        return Math.Round(originalPrice * (Percentage / 100),2);
    }
}