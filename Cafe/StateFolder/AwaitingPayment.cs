using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class AwaitingPayment : State //Waiting Payment
    {
        public AwaitingPayment(Order order) : base(order)
        {
            WaitPayment();
        }

        public override void AtCustomer() { }

        public override void DoneOrder() { }

        public override void FinishedAll() { }

        public override void InTreatment() { }

        public override void MaterialsMissing() { }

        public override void MoveKitchen() { }

        public override void TransferredWaiter() { }

        public override void WaitPayment()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The order is waiting for payment");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
