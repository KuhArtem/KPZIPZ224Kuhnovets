using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab1Lib
{
    public class Reporting : IReporting
    {
        public void GenerateInventoryReport(IWarehouse warehouse)
        {
            if (warehouse == null) throw new ArgumentNullException(nameof(warehouse), "Склад не може бути null");

            var inventory = warehouse.GetInventory();
            foreach (var product in inventory)
            {
                Console.WriteLine($"Товар: {product.Name}, Ціна: {product.Price}");
            }
        }
    }
}
