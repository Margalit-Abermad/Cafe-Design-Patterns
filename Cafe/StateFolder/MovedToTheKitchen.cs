using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class MovedToTheKitchen : State //Moved to the kitchen
    {
        public MovedToTheKitchen(Order order) : base(order)
        {
            MoveKitchen();
        }
        public override void AtCustomer() { }

        public override void DoneOrder() { }

        public override void InTreatment() { }

        public override void FinishedAll() { }

        public override void MaterialsMissing() { }

        public override void MoveKitchen()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The order was moved to the kitchen");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //order.ChangeState(new Treatment(order));
        }

        public override void TransferredWaiter() { }

        public override void WaitPayment() { }


    }
}

