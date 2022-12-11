using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class Treatment : State //Done
    {
        public Treatment(Order order) : base(order)
        {
            InTreatment();
        }

        public override void AtCustomer() { }

        public override void DoneOrder() { }

        public override void InTreatment() 
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The chef begins to prepare the order...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //order.ChangeState(new Done(order));
            //Random r = new Random();
            //int rand = r.Next(0, 10);
            //if(rand == 3)
            //{
            //    order.ChangeState(new CanceledDueToLackOfMaterials(order));
            //} 
        }

        public override void FinishedAll() { }

        public override void MaterialsMissing() { }

        public override void MoveKitchen() { }

        public override void TransferredWaiter() { }

        public override void WaitPayment() { }
    }
}
