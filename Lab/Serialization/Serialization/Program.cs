using Catalog;
using System.Text.Json;
using System.Text.Json.Serialization;

Product p1 = new Product { Id = 1, Title = "Gerbera", Description = "Smelling Flower", UnitPrice = 50 };
Product p2 = new Product { Id = 13, Title = "Rose", Description = "Valentine flower", UnitPrice = 34 };
Product p3 = new Product { Id = 14, Title = "Lotus", Description = "Worhip flower", UnitPrice = 28 };
Product p4 = new Product { Id = 15, Title = "Jasmine", Description = "Smelling flower", UnitPrice = 2 };

List<Product> flowers = new List<Product>();

flowers.Add(p1);
flowers.Add(p2);
flowers.Add(p3);
flowers.Add(p4);

// Console.WriteLine(flowers);

foreach (Product p in flowers)
    Console.WriteLine(p);

try
{
    //Serialization
    var options = new JsonSerializerOptions { IncludeFields = true };
    var productsJson = JsonSerializer.Serialize<List<Product>>(flowers, options);
    string filename = @"D:\DotNet\Serialization\Products.json";
    File.WriteAllText(filename, productsJson);

    //Deserialization
    string jsonString = File.ReadAllText(filename);
    List<Product> jsonFlowers = JsonSerializer.Deserialize<List<Product>>(jsonString);
    Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
    foreach (Product f in jsonFlowers)
    {
        Console.WriteLine($"{f.Id}: {f.Title}: {f.Description}: {f.UnitPrice}");
    }



}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
