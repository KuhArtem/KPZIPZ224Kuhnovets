using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab1Lib
{
    public class Product : IProduct
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Назва продукту не може бути пустою або null", nameof(name));
            if (price == null) throw new ArgumentNullException(nameof(price), "Ціна не може бути null");

            Name = name;
            Price = price;
        }

        public void ReducePrice(Money amount)
        {
            if (amount == null || amount.Dollars < 0 || amount.Cents < 0)
                throw new ArgumentException("Сума зниження ціни має бути позитивною", nameof(amount));

            Price = Price.Subtract(amount);
        }
    }
}
