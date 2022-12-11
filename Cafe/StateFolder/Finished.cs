using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class Finished : State //Finished
    {
        public Finished(Order order) : base(order)
        {
            FinishedAll();
        }

        public override void AtCustomer() { }

        public override void DoneOrder() { }

        public override void InTreatment() { }

        public override void FinishedAll() 
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The customer received the order \nIn appetite!!!");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public override void MaterialsMissing() { }

        public override void MoveKitchen() { }

        public override void TransferredWaiter() { }

        public override void WaitPayment() { }
    }
}
