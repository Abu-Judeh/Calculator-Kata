namespace Calculator_Kata;

public abstract class Discount
{
    public decimal Percentage { get; set; }

    public Discount(decimal percentage)
    {
        Percentage = percentage;
    }

    public abstract decimal Apply(decimal price, decimal taxPercentage);
}