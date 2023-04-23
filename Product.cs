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

    public decimal GetPriceWithTax(decimal taxPercentage)
    {
        return Math.Round(Price * (1 + taxPercentage / 100), 2);
    }

    public decimal GetPriceWithTaxAndDiscount(decimal taxPercentage, decimal discountPercentage)
    {
        decimal priceWithTax = GetPriceWithTax(taxPercentage);
        decimal discountAmount = Math.Round(Price * (discountPercentage / 100), 2);
        return Math.Round(priceWithTax - discountAmount, 2);
    }

    
}