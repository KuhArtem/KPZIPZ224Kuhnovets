using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab1Lib
{
    public interface IWarehouse
    {
        void AddProduct(IProduct product);
        bool RemoveProduct(string productName);
        IProduct FindProductByName(string name);
        IEnumerable<IProduct> GetInventory();
    }
}
