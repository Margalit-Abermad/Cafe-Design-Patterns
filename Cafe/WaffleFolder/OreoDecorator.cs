using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.WaffleFolder
{
    internal class OreoDecorator:WaffleDecorator
    {
        public OreoDecorator(Waffle waffle) : base(waffle)
        {

        }
        public override double GetCost()
        {
            return waffle.GetCost() + 3;
        }
    }
}
