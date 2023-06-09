namespace Calculator_Kata;

public class Product
{
    public string Name { get; set; }
    public int UPC { get; set; }
    public decimal Price { get; set; }

    public string Currency { get; set; }
    public decimal Cap { get; set; }
    
    public bool IsPercentageCap { get; set; }
    public List<Cost> AdditionalCosts { get; set; }

    public Product(string name, int upc, decimal price,string currency,decimal cap,bool isPercentageCap)
    {
        Name = name;
        UPC = upc;
        Price = price;
        Cap = cap;
        IsPercentageCap = isPercentageCap;
        Currency = currency;
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
        return Math.Round(totalCost,4);
    }

    public decimal GetTotalDiscountAmount(List<Discount> discounts, DiscountCombinationMethod method)
    {
        decimal final;
        if (method == DiscountCombinationMethod.Additive)
        {
             final= discounts.Sum(discount => discount.GetDiscountAmount(Price));
        }
        else // Multiplicative
        {
            decimal discountedPrice = Price;
            foreach (Discount discount in discounts)
            {
                decimal discountAmount = discount.GetDiscountAmount(Price);
                discountedPrice -= discountAmount;
            }
            final =Price - discountedPrice;
        }

        Discount temp = new UniversalDiscount(Price);
        return final = temp.GetCapDiscount(Price, final, Cap, IsPercentageCap);
    }
}
