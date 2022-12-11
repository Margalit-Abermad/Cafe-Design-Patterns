using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    internal class ReadyState : State
    {
        public State state { get; set; }

        public ReadyState(Order order) : base(order)
        {

        }

        public override void AtCustomer()
        {
            //return "The order at the customer";
        }

        public override void DoneOrder()
        {
            //return "The chef has finished preparing the order,\n" +
            //" immediately the waiter will come to fetch the order";
        }

        public override void FinishedAll()
        {
            //return "The order was paid and delivered to the customer";
        }

        public override void MaterialsMissing()
        {
            //return "we're sorry!\n" +
            //"Missing products for order received\n" +
            //"We will try to get them as quickly as possible";
        }

        public override void MoveKitchen()
        {
            //return "The order was moved to the kitchen";
        }

        public override void TransferredWaiter()
        {
            //return "The order was received from the waiter and will be\n" +
            //       " forwarded to the chef.";
        }

        public override void WaitPayment()
        {
            //return "The order is waiting for payment,\n" +
            //    " as soon as it is paid it will be accepted by the customer";
        }

        public override void InTreatment()
        {
            //return "The order is being processed"
        }
    }
}
