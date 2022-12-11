using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.WaffleFolder;
using Cafe.StateFolder;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;


namespace Cafe
{
    internal class Details
    {    
        List<Order> AllOrder = new List<Order>();
        
        Waiters waiters = new Waiters();
        public Chef chef { get; set; }
        public Order order { get; set; }
        public Details()
        {
            chef = Chef.GetInstance();
            order = new Order();       
        }
        public void Detail()
        {
            order.ChangeState(new AtTheCustomer(order));
            Console.WriteLine("Enter your name \n");
            string name = Console.ReadLine();
            order.Name = name;
            order.Price = 0;
            Console.WriteLine($"Hi {name}! \nPlease select what you want to order: \n");
            Print();
        }

        #region Menu
        public void Print()
        {
            Console.WriteLine("" +
                "press 1 for Belgian Waffles \n" +
                "press 2 for Hot drink \n" +
                "press 3 for cold drink \n" +
                "press 4 for An order I placed in the past \n" +
                "press 0 for End of order \n");
            int m = int.Parse(Console.ReadLine());
            Send(m);
        }
        #endregion

        #region Send order
        public void Send(int m)
        {
            switch (m)
            {
                case 1:
                    AddWaffle();
                    break;
                case 2:
                    AddHotDrink();
                    break;
                case 3:
                    AddColdDrink();
                    break;
                case 4:
                    PreviousOrder();
                    break;
                case 0:
                    End();
                    return;
                default:
                    Console.WriteLine("Error! Please select again \n ");
                    Print();
                    break;
            }
            Print();
        }
        #endregion

        #region AddWaffle
        public void AddWaffle()
        {
            DetailsWaffle detailsWaffle = new DetailsWaffle();
            Console.WriteLine("Please select a shape for a Belgian waffle:\n" +
            "Press 1 for square \n" +
            "Press 2 for circle \n");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                detailsWaffle.Shape = "square";
            }
            else
            {
                detailsWaffle.Shape = "circle";
            }
            Decoretors(detailsWaffle);
            order.OrderList.Add((Food)detailsWaffle);
        }

        public void Decoretors(DetailsWaffle detailsWaffle)
        {
            Console.WriteLine("Please select the desired extension \n" +
                        "press 1 for chocolate \n" +
                        "perss 2 for klik \n" +
                        "perss 3 for oreo \n" +
                        "press 4 for Pecan \n" +
                        "perss 0 for finished \n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    detailsWaffle.decorators.Add("chocolate");
                    break;
                case 2:
                    detailsWaffle.decorators.Add("klik");
                    break;
                case 3:
                    detailsWaffle.decorators.Add("oreo");
                    break;
                case 4:
                    detailsWaffle.decorators.Add("Pecan");
                    break;
                case 0: return;
                default:
                    Console.WriteLine("Error! Please select again \n");
                    break;
            }
            Decoretors(detailsWaffle);
        }

        #endregion

        #region AddHotDrink
        public void AddHotDrink()
        {
            DetailsHotDrink detailsHotDrink = new DetailsHotDrink();
            order.OrderList.Add((Food)detailsHotDrink);
        }

        #endregion

        #region AddColdDrink
        public void AddColdDrink()
        {
            DetailsColdDrink detailsColdDrink = new DetailsColdDrink();
            order.OrderList.Add((Food)detailsColdDrink);
            //order.ChangeState(Treatment(order));
        }

        #endregion

        #region PreviousOrder
        public void PreviousOrder()//הזמנה קודמת
        {
            Console.WriteLine("Enter Your previous order number");
            int Previous = int.Parse(Console.ReadLine());
            foreach (var item in AllOrder)
            {
                if (item.Name == order.Name && item.Id == Previous)
                {
                    order.Clone(item.OrderList);
                }
                //else Console.WriteLine("Error!, you don't have a previus order!\n select again...");
            }
        }

        #endregion

        #region End
        public void End()
        {
            order.ChangeState(new TransferredToWaiter(order));
            chef.orders.Enqueue(order);
            AllOrder.Add(order);
            chef.WaiterGet(waiters);
            order.ChangeState(new MovedToTheKitchen(order));
            waiters.MovesToTheKitchen();
            
        }

        #endregion   

    }
}

