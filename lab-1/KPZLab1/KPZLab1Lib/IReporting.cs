using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab1Lib
{
    public interface IReporting
    {
        void GenerateInventoryReport(IWarehouse warehouse);
    }
}
