﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Strategy_Save_Data
{
    class SaveDB : StrategySaveData
    {
        public override void Save(Order order)
        {
            //save the data in the database
        }
    }
}
