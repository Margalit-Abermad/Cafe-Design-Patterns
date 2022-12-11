using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
     interface  OrderPrototype
    {
        Order Clone(List<Food> OrderList);
    }
}
