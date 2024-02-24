using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace KPZLab1Lib
{
    public class Warehouse : IWarehouse
    {
        private readonly List<IProduct> products = new();

        public void AddProduct(IProduct product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product), "Не можна додати товар null на склад");

            products.Add(product);
        }

        public bool RemoveProduct(string productName)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            return product != null && products.Remove(product);
        }

        public IProduct FindProductByName(string name) => products.FirstOrDefault(p => p.Name == name);

        public IEnumerable<IProduct> GetInventory() => products.AsReadOnly();
    }
}
