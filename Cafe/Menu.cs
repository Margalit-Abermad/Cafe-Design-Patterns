using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Cafe.WaffleFolder;
using System.Drawing;
using Cafe.StateFolder;
using System.Text.Json;
using System.IO;

namespace Cafe
{
    internal class Menu
    {
        List<Order> AllOrder = new List<Order>();
        public double PriceWaffle { get; set; }
        public void MakeOrder(Order orderChef)
        {
            orderChef.ChangeState(new Treatment(orderChef));
            //orderChef.ChangeState(new CanceledDueToLackOfMaterials(orderChef));
            List<Food> OrderList = orderChef.OrderList;
            foreach (var item in OrderList)
            {
                if (item is DetailsWaffle)
                {
                    MakeWaffle(item as DetailsWaffle, orderChef);
                }
                else if (item is DetailsHotDrink)
                {
                    MakeHotDrink(item as DetailsHotDrink, orderChef);
                }
                else MakeColdDrink(item as DetailsColdDrink, orderChef);
            }
            EndAndPayment(orderChef);
        }

        #region MakeWaffle
        public void MakeWaffle(DetailsWaffle item, Order orderChef)
        {
            
            Waffle w;
            if (item.Shape== "Square")
            {
                w = new Square();
            }
            else
            {
                w = new Circle();
            }
            Console.WriteLine("Begins to make the waffle...");
            Thread.Sleep(2000);
            PriceWaffle = w.GetCost(); 
            orderChef.Price += Decoretors(w, item.decorators, orderChef, PriceWaffle);
            Console.WriteLine();
        }

        public double Decoretors(Waffle w, List<string> decorators,Order orderChef , double PriceWaffle)
        {         
            foreach (var decorator in decorators)
            {             
                switch (decorator)
                {
                    case "chocolate":
                        ChocolateDecorator chocolateDecorator = new ChocolateDecorator(w);
                        w = chocolateDecorator;
                        Console.WriteLine("Adds chocolate...");
                        Thread.Sleep(1000);
                        PriceWaffle = w.GetCost();
                        break;
                    case "klik":
                        KlikDecorator klikDecorator = new KlikDecorator(w);
                        w = klikDecorator;
                        Console.WriteLine("Adds klik...");
                        Thread.Sleep(1000);
                        PriceWaffle = w.GetCost();
                        break;
                    case "oreo":
                        OreoDecorator oreoDecorator = new OreoDecorator(w);
                        w = oreoDecorator;
                        Console.WriteLine("Adds oreo...");
                        Thread.Sleep(1000);
                        PriceWaffle = w.GetCost();
                        break;
                    case "Pecan":
                        PecanDecorator pecanDecorator = new PecanDecorator(w);
                        w = pecanDecorator;
                        Console.WriteLine("Adds pecan...");
                        Thread.Sleep(1000);
                        PriceWaffle = w.GetCost();
                        break;
                    default:
                        //Decoretors(w, decorators, orderChef, PriceWaffle);
                        break;
                }
            }
            return PriceWaffle;   
        }

        #endregion


        #region MakeHotDrink
        public void MakeHotDrink(DetailsHotDrink item,Order orderChef)
        {
            Console.WriteLine("Begins to make a hot drink...");
            Thread.Sleep(2000);
            HotDrink hotDrink = new HotDrink();
            Console.WriteLine(hotDrink.Boil().ToString());
            Thread.Sleep(2000);
            Console.WriteLine(hotDrink.Coffee().ToString());
            Thread.Sleep(1000);
            Console.WriteLine(hotDrink.Sugar().ToString());
            Thread.Sleep(1000);
            Console.WriteLine(hotDrink.Water().ToString());
            Thread.Sleep(1000);
            Console.WriteLine(hotDrink.Milk().ToString());
            orderChef.Price += hotDrink.GetCost();
            Console.WriteLine();
        }

        #endregion


        #region MakeColdDrink
        public void MakeColdDrink(DetailsColdDrink item,Order orderChef)
        {
            Console.WriteLine("Starting to make a cold drink...");
            Thread.Sleep(2000);
            ColdDrink coldDrink = new ColdDrink();
            Console.WriteLine(coldDrink.Pour().ToString());
            Thread.Sleep(1000);
            Console.WriteLine(coldDrink.IceCubes().ToString());
            Thread.Sleep(1000);
            orderChef.Price += coldDrink.GetCost();
            Console.WriteLine();
        }

        #endregion


        #region EndAndPayment
        public void EndAndPayment(Order orderChef)
        {
            orderChef.ChangeState(new Done(orderChef));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The bell rings...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }
            Console.WriteLine("\n" + orderChef.Name + " Thank you for buying from us! ");
            Console.WriteLine("For payment: " + orderChef.Price + "$");
            orderChef.ChangeState(new AwaitingPayment(orderChef));
            orderChef.ChangeState(new Finished(orderChef));
        }
        #endregion
    }
}
