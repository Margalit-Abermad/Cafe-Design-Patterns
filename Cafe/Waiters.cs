using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Cafe.StateFolder;

namespace Cafe
{
    internal class Waiters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }

        public Order orderCommand { get; set; }//Command

        Order OrderCommand = new Order();

        public Waiters waiters { get; set; }

        public Chef chef { get; set; }
        public Waiters()
        {
            Available = true;
            OrderCommand = new Order();
            chef = Chef.GetInstance();
        }

        public void MovesToTheKitchen()//During the treatment, the waiter delivers the order
        {
            Thread.Sleep(1000);
            OrderCommand.Execute(chef);
        }
    }
}
