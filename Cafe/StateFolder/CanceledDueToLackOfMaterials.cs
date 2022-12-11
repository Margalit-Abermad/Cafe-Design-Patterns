using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cafe.StateFolder
{
    class CanceledDueToLackOfMaterials : State //Cencel- dosent have all meterials
    {
        int num = 0;
        public CanceledDueToLackOfMaterials(Order order) : base(order)
        {
            MaterialsMissing();
        }
        public override void AtCustomer() { }

        public override void DoneOrder() { }

        public override void FinishedAll() { }

        public override void InTreatment() { }

        public override void MaterialsMissing(){ }

        public override void MoveKitchen() { }

        public override void TransferredWaiter() { }

        public override void WaitPayment() { }
    }
}
