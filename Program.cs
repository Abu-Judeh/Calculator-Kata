using Calculator_Kata;

Product book1 = new Product("The Little Prince", 12345, 20.25m,"USD",1000m,false);
//Product book2 = new Product("The Alchemist", 67890, 15.99m,"USD",4m,false);

// Add additional costs
//book1.AddCost(new Cost("Packaging", 1m,true));
book1.AddCost(new Cost("Transport", 3m,true));

//book2.AddCost(new Cost("Packaging", 1m,true));
//book2.AddCost(new Cost("Transport", 2.2m,false));

// Define tax, discounts and discount combination method
decimal taxPercentage = 21m;
List<Discount> discounts = new List<Discount>
{
    new UniversalDiscount(15m),
    new UpcDiscount(12345, 7m)
};

DiscountCombinationMethod discountCombinationMethod = DiscountCombinationMethod.Multiplicative;

// Calculate and display results
List<Product> products = new List<Product> { book1 };

foreach (Product book in products)
{
    Console.WriteLine($"Product: {book.Name}, UPC: {book.UPC}");
    Console.WriteLine($"Price: ${book.Price} ${book.Currency}" );

    decimal totalDiscountAmount = book.GetTotalDiscountAmount(discounts, discountCombinationMethod);
    decimal totalPriceWithTax = book.Price + Math.Round(book.Price * (taxPercentage / 100),4);
    decimal finalPrice = totalPriceWithTax - totalDiscountAmount;

    foreach (Cost cost in book.AdditionalCosts)
    {
        finalPrice += cost.GetCost(book.Price);
    }

    Console.WriteLine($"Cost: ${book.Price} ${book.Currency}");
    Console.WriteLine($"Tax: ${Math.Round(book.Price * (taxPercentage / 100), 2)} ${book.Currency}");
    Console.WriteLine($"Discounts: ${totalDiscountAmount} ${book.Currency}");

    foreach (Cost cost in book.AdditionalCosts)
    {
        Console.WriteLine($"{cost.Description}: ${Math.Round(cost.GetCost(book.Price),2)} ${book.Currency}");
    }

    Console.WriteLine($"TOTAL: ${Math.Round(finalPrice, 2)} ${book.Currency}");
    Console.WriteLine();
}