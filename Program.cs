using Calculator_Kata;

Product book = new Product("The Little Prince", "12345", (decimal)20.25);
const decimal tax=20;
decimal totalPrice=book.getFinalPrice(tax);

Console.WriteLine("Product: " + book.name);
Console.WriteLine("UPC: " + book.upc);
Console.WriteLine("Price before tax: " + book.price.ToString("C"));
Console.WriteLine("Price with tax: " + totalPrice.ToString("C"));