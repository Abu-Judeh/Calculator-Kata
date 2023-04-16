namespace Calculator_Kata;

public class PriceCalculator
{
    private decimal TaxPercentage { get; set; }
    private decimal DiscountPercentage{ get; set; }

    public PriceCalculator(decimal taxPercentage,decimal discountPercentage)
    {
        this.TaxPercentage = taxPercentage;
        this.DiscountPercentage = discountPercentage;
    }

    public decimal CalculateTax(decimal price)
    {
        return price * (TaxPercentage/100);
        
    }
    public decimal CalculateAfterTax(decimal price)
    {
        return price * (1+TaxPercentage/100);
        
    }

    public decimal CalculateDiscount(decimal price)
    {
        return price * (DiscountPercentage/100);
        
    }
    public decimal CalculateAfterDiscount(decimal price)
    {
        return price * (1-DiscountPercentage/100);
        
    }
    public decimal CalculateFinalPrice(decimal price)
    {
        return CalculateAfterTax(price) - CalculateDiscount(price);

    }
    
}