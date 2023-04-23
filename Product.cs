namespace Calculator_Kata;

public class Product
{
    public string Name { get; set; }
    public int UPC { get; set; }
    public decimal Price { get; set; }

    public Product(string name, int upc, decimal price)
    {
        Name = name;
        UPC = upc;
        Price = price;
    }

    public decimal GetPriceWithTaxAndDiscounts(decimal taxPercentage, List<Discount> discounts)
    {
        decimal currentPrice = Price;

        // Apply before tax discounts
        foreach (BeforeTaxDiscount discount in discounts.OfType<BeforeTaxDiscount>())
        {
            currentPrice = discount.Apply(currentPrice, taxPercentage);
        }

        // Apply tax
        decimal taxAmount = Math.Round(currentPrice * (taxPercentage / 100), 2);
        currentPrice += taxAmount;

        // Apply after tax discounts
        foreach (AfterTaxDiscount discount in discounts.OfType<AfterTaxDiscount>())
        {
            currentPrice = discount.Apply(currentPrice, taxPercentage);
        }

        return Math.Round(currentPrice, 2);
    }
}