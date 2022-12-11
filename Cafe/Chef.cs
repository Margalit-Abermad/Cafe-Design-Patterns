using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.StateFolder;
using System.Threading;

namespace Cafe
{
    class Chef
    {
        static Chef chef;
        public string Name { get; set; }
        public Queue<Order> orders { get; set; }//orders Queue
        public Order order { get; set; }
        public Menu menu { get; set; }
        public bool Bell { get; set; }
        public Waiters waiters { get; set; }

       
        private Chef()
        {
            orders = new Queue<Order>();
            menu = new Menu();
            Bell = false;
        }

        public static Chef GetInstance()
        {
            if (chef == null)
            {
                chef = new Chef();
            }
            return chef;
        }
 
        public void WaiterGet(Waiters waiters)
        {
            this.waiters = waiters;
        }

        public void Make()
        {
            order = orders.Dequeue();//first order
            menu.MakeOrder(order);
            Bell = true;
            Thread.Sleep(3000);
            Bell = false;
        }
    }
}
