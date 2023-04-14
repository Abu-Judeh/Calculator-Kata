namespace Calculator_Kata;

public class Product
{
    private string Name;
    private string UPC;
    private decimal Price;

    public Product(string Name,string UPC,decimal Price)
    {
        this.Name = Name;
        this.UPC = UPC;
        this.Price = Price;
    }

    public string name
    {
        get { return Name;}
        set { Name=value; }
    }
    public string upc 
    {
        get { return UPC;}
        set { UPC=value; } 
    }
    
    public decimal price 
    {
        get { return Price;}
        set { Price=value; } 
    }

    public decimal getFinalPrice(decimal taxPercent)
    {
        decimal taxTot = Price * (taxPercent / 100);
        return Price + taxTot;
    }
}