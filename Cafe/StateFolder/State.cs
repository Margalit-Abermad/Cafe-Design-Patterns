namespace Cafe.StateFolder
{
    abstract class State
    {
        protected Order order { get; set; }
        public State(Order order)
        {
            this.order = order;    
        }

        public abstract void AtCustomer();// in the customers
        public abstract void TransferredWaiter();//moved a waiter
        public abstract void MoveKitchen();// moved the kitchen
        public abstract void MaterialsMissing();//miss meterials
        public abstract void InTreatment();// in treatment
        public abstract void DoneOrder();// Done
        public abstract void WaitPayment(); //Waiting Payment
        public abstract void FinishedAll();// finally' after payment
    }
}

