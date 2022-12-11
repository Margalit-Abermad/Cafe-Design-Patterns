using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    #region HotRegion
    internal class HotDrink
    {
        public int Price { get; set; }
        
        public string Boil()
        {
            return "Boiling water...";
        }
        public string Coffee()
        {
            return "Add coffee to glass...";
        }

        public string Sugar()
        {
            return "Add sugar to glass...";
        }

        public string Water()
        {
            return "Add water to glass...";
        }

        public string Milk()
        {
            return "Add milk to glass...";
        }

        public double GetCost()
        {
            return 10;
        }
    }
    #endregion
}
