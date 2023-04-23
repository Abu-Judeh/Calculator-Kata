namespace Calculator_Kata;

public class Cost
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public bool IsPercentage { get; set; }

    public Cost(string description, decimal amount, bool isPercentage)
    {
        Description = description;
        Amount = amount;
        IsPercentage = isPercentage;
    }

    public decimal GetCost(decimal price)
    {
        return IsPercentage ? Math.Round(price * (Amount / 100), 2) : Amount;
    }
}