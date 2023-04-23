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

    public decimal GetPriceWithTaxAndDiscounts(decimal taxPercentage, decimal discountPercentage, decimal upcDiscountPercentage, int upcForDiscount)
    {
        decimal priceWithTax = GetPriceWithTax(taxPercentage);
        decimal universalDiscountAmount = Math.Round(Price * (discountPercentage / 100), 2);
        decimal upcDiscountAmount = UPC == upcForDiscount ? Math.Round(Price * (upcDiscountPercentage / 100), 2) : 0;
        return Math.Round(priceWithTax - universalDiscountAmount - upcDiscountAmount, 2);
    }

    
}