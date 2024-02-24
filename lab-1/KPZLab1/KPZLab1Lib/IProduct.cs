using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab1Lib
{
    public interface IProduct
    {
        string Name { get; }
        Money Price { get; }
        void ReducePrice(Money amount);
    }
}
