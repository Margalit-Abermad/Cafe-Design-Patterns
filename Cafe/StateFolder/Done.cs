using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class Done : State //Done
    {
        public Done(Order order) : base(order)
        {
            DoneOrder();
        }
        public override void AtCustomer() { }

        public override void DoneOrder()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The order is ready");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //order.ChangeState(new AwaitingPayment(order));
        }

        public override void InTreatment() { }

        public override void FinishedAll() { }

        public override void MaterialsMissing() { }

        public override void MoveKitchen() { }

        public override void TransferredWaiter() { }

        public override void WaitPayment() { }
    }
}
