using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cafe.Strategy_Save_Data
{
    class SaveJson : StrategySaveData
    {
        public override void Save(Order order)
        {
            string strJson = JsonSerializer.Serialize<Order>(order);
            StreamWriter History = new("H:\\Cafe\\Save.Json", true);
            History.WriteLine(strJson);
            History.Close();
        }
    }
}
