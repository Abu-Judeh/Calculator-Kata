using Calculator_Kata;
using System;
using System.Collections.Generic;
using System.Linq;

Product book1 = new Product("The Little Prince", 12345, 20.25m);
book1.AdditionalCosts.Add(new Cost("Packaging", 1, true));
book1.AdditionalCosts.Add(new Cost("Transport", 2.2m, false));

Product book2 = new Product("The Little Prince", 789, 20.25m);

List<Product> books = new List<Product> { book1, book2 };

decimal taxPercentage = 21;
List<Discount> discounts = new List<Discount>
{
    new BeforeTaxDiscount(7),
    new AfterTaxDiscount(15)
};

foreach (Product book in books)
{
    Console.WriteLine($"Product: {book.Name}");
    Console.WriteLine($"UPC: {book.UPC}");
    Console.WriteLine($"Price before tax, discounts, and additional costs: ${book.Price}");

    decimal finalPrice = book.GetPriceWithTaxDiscountsAndCosts(taxPercentage, discounts);
    Console.WriteLine($"Price after {taxPercentage}% tax, discounts, and additional costs: ${finalPrice}");

    decimal upcDiscountAmount = Math.Round(book.Price * 7 / 100, 2);
    decimal universalDiscountAmount = Math.Round((book.Price - upcDiscountAmount) * 15 / 100, 2);
    decimal totalDiscountAmount = upcDiscountAmount + universalDiscountAmount;

    Console.WriteLine($"Cost: ${book.Price}");
    Console.WriteLine($"Tax: ${Math.Round(book.Price * (taxPercentage / 100), 2)}");
    Console.WriteLine($"Discounts: ${totalDiscountAmount}");

    foreach (Cost cost in book.AdditionalCosts)
    {
        Console.WriteLine($"{cost.Description}: ${cost.GetCost(book.Price)}");
    }

    Console.WriteLine($"TOTAL: ${finalPrice}");
    Console.WriteLine();
}

Console.ReadLine();