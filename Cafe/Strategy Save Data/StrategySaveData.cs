using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Strategy_Save_Data
{
    abstract class StrategySaveData
    {
        public abstract void Save(Order order);
    }
}
