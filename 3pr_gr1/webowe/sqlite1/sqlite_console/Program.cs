// See https://aka.ms/new-console-template for more information
using sqlite_console;

Console.WriteLine("Hello, World!");

ProductRepo db = new ProductRepo();
db.getProducts();
