namespace Calculator_Kata;

public class Product
{
    public string Name { get; set; }
    public int UPC { get; set; }
    public decimal Price { get; set; }
    public List<Cost> AdditionalCosts { get; set; }

    public Product(string name, int upc, decimal price)
    {
        Name = name;
        UPC = upc;
        Price = price;
        AdditionalCosts = new List<Cost>();
    }

    public void AddCost(Cost cost)
    {
        AdditionalCosts.Add(cost);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = Price;
        foreach (Cost cost in AdditionalCosts)
        {
            totalCost += cost.GetCost(Price);
        }
        return Math.Round(totalCost,2);
    }

    public decimal GetTotalDiscountAmount(List<Discount> discounts, DiscountCombinationMethod method)
    {
        if (method == DiscountCombinationMethod.Additive)
        {
            return discounts.Sum(discount => discount.GetDiscountAmount(Price));
        }
        else // Multiplicative
        {
            decimal discountedPrice = Price;
            foreach (Discount discount in discounts)
            {
                decimal discountAmount = discount.GetDiscountAmount(discountedPrice);
                discountedPrice -= discountAmount;
            }
            return Price - discountedPrice;
        }
    }
}
