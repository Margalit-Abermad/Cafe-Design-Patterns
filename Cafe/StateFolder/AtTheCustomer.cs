using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class AtTheCustomer : State //אצל הלקוח
    {
        public AtTheCustomer(Order order) : base(order)
        {
            AtCustomer();
        }
        public override void AtCustomer()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The order at the customer");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public override void DoneOrder() { }

        public override void FinishedAll() { }

        public override void InTreatment(){ }

        public override void MaterialsMissing() { }

        public override void MoveKitchen() { }

        public override void TransferredWaiter() { }

        public override void WaitPayment() { }
    }
}
