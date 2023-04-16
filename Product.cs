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

    
}