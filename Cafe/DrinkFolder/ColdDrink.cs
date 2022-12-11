using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    #region ColdDrink
    internal class ColdDrink
    {
        public int Price { get; set; }

        public string Pour()
        {
            return "Pour into a glass...";
        }
        public string IceCubes()
        {
            return "Adds ice cubes...";
        }

        public double GetCost()
        {
            return 7;
        }
    }
    #endregion
}
