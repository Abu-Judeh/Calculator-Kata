using Calculator_Kata;

Product book = new Product("The Little Prince", 12345, (decimal)20.25);
const decimal tax=20;
const decimal discount = 15;
PriceCalculator Calc = new PriceCalculator(tax, discount);

Console.WriteLine("Product: " + book.Name);
Console.WriteLine("UPC: " + book.UPC);
Console.WriteLine("Price before tax and discount: " + book.Price.ToString("C"));
Console.WriteLine("Final price: " + Calc.CalculateFinalPrice(book.Price));
Console.WriteLine("Tax Amount: " + Calc.CalculateTax(book.Price));
Console.WriteLine("discount Amount: " + Calc.CalculateDiscount(book.Price));