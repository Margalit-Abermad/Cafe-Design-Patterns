using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.WaffleFolder
{
    internal class ChocolateDecorator: WaffleDecorator
    {
        public ChocolateDecorator(Waffle waffle) : base(waffle)
        {

        }
        public override double GetCost()
        {
            return waffle.GetCost() + 3;
        }
    }
}
