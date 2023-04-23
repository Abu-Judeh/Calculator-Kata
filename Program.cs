using Calculator_Kata;

Product book = new Product("The Little Prince", 12345, 20.25m);

Console.WriteLine($"Product: {book.Name}");
Console.WriteLine($"UPC: {book.UPC}");
Console.WriteLine($"Price before tax and discounts: ${book.Price}");

decimal taxPercentage = 20;
decimal universalDiscountPercentage = 15;
decimal upcDiscountPercentage = 7;
int upcForDiscount = 12345;

decimal finalPrice = book.GetPriceWithTaxAndDiscounts(taxPercentage, universalDiscountPercentage, upcDiscountPercentage, upcForDiscount);
Console.WriteLine($"Price after {taxPercentage}% tax, {universalDiscountPercentage}% universal discount, and {upcDiscountPercentage}% UPC discount: ${finalPrice}");

decimal totalDiscountAmount = Math.Round(book.Price * (universalDiscountPercentage / 100), 2) + (book.UPC == upcForDiscount ? Math.Round(book.Price * (upcDiscountPercentage / 100), 2) : 0);
Console.WriteLine($"Total discount amount: ${totalDiscountAmount}");