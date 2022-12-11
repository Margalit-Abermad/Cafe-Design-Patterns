using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.WaffleFolder
{
    abstract class WaffleDecorator:Waffle
    {
        
        protected Waffle waffle;
        public WaffleDecorator(Waffle waffle)
        {
            this.waffle = waffle;
        }

        
    }
}
