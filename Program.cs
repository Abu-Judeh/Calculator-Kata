using Calculator_Kata;

Product book = new Product("The Little Prince", 12345, 20.25m);

Console.WriteLine($"Product: {book.Name}");
Console.WriteLine($"UPC: {book.UPC}");
Console.WriteLine($"Price before tax and discount: ${book.Price}");

decimal taxPercentage = 20;
decimal discountPercentage = 0;

Console.WriteLine($"Price after {taxPercentage}% tax: ${book.GetPriceWithTax(taxPercentage)}");

decimal finalPrice = book.GetPriceWithTaxAndDiscount(taxPercentage, discountPercentage);
Console.WriteLine($"Price after {taxPercentage}% tax and {discountPercentage}% discount: ${finalPrice}");

if (discountPercentage > 0)
{
    decimal discountAmount = Math.Round(book.Price * (discountPercentage / 100), 2);
    Console.WriteLine($"Discounted amount: ${discountAmount}");
}

Console.ReadLine();