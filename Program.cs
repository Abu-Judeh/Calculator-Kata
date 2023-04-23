using Calculator_Kata;

Product book = new Product("The Little Prince", 12345, 20.25m);

Console.WriteLine($"Product: {book.Name}");
Console.WriteLine($"UPC: {book.UPC}");
Console.WriteLine($"Price before tax and discounts: ${book.Price}");

decimal taxPercentage = 20;
List<Discount> discounts = new List<Discount>
{
    new BeforeTaxDiscount(7),
    new AfterTaxDiscount(15)
};

decimal finalPrice = book.GetPriceWithTaxAndDiscounts(taxPercentage, discounts);
Console.WriteLine($"Price after {taxPercentage}% tax and discounts: ${finalPrice}");

decimal upcDiscountAmount = Math.Round(book.Price * 7 / 100, 2);
decimal universalDiscountAmount = Math.Round((book.Price - upcDiscountAmount) * 15 / 100, 2);
decimal totalDiscountAmount = upcDiscountAmount + universalDiscountAmount;
Console.WriteLine($"Total discount amount: ${totalDiscountAmount}");
