using KPZLab1Lib;
class Program
{
    static void Main(string[] args)
    {
        var money1 = new Money(10, 75); // 10 гривень 75 копійок
        Console.WriteLine($"Початкова сума: {money1}");

        var product1 = new Product("Яблуко", new Money(1, 25)); // 1 гривня 25 копійок
        Console.WriteLine($"Товар до зниження ціни: {product1.Name}, Ціна: {product1.Price}");

        product1.ReducePrice(new Money(0, 25)); // Зниження на 25 копійок
        Console.WriteLine($"Товар після зниження ціни: {product1.Name}, Ціна: {product1.Price}");

        var warehouse = new Warehouse();
        warehouse.AddProduct(product1);
        Console.WriteLine("Інвентар складу після додавання товару:");
        foreach (var product in warehouse.GetInventory())
        {
            Console.WriteLine($"Товар: {product.Name}, Ціна: {product.Price}");
        }

        var reporting = new Reporting();
        Console.WriteLine("\nГенерація звіту про інвентар:");
        reporting.GenerateInventoryReport(warehouse);
    }
}