using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class TransferredToWaiter : State //transferred to waiter
    {
        public TransferredToWaiter(Order order) : base(order)
        {
            TransferredWaiter();
        }

        public override void AtCustomer() { }

        public override void DoneOrder() { }

        public override void InTreatment() { }

        public override void FinishedAll() { }

        public override void MaterialsMissing() { }

        public override void MoveKitchen() { }

        public override void TransferredWaiter()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The waiter got your order");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //order.ChangeState(new MovedToTheKitchen(order));
        }

        public override void WaitPayment() { }


    }
}
