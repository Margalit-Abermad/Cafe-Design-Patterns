using Cafe.StateFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.Strategy_Save_Data;

namespace Cafe
{
    internal class Order : OrderPrototype
    {
        public static int Mis;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime Date { get; set; }

        public Chef chef { get; set; }


        public List<Food> OrderList = new List<Food>();

        private StrategySaveData strategySaveData;

        static Order()
        {
            Mis = 0;
        }
        public Order()
        {
            Mis++;
            Date = DateTime.Now;
            Id = Mis;
            Price = 0;
            state = new ReadyState(this);
        }

        public Order(List<Food> OrderList)
        {
            this.OrderList = OrderList;
        }


        #region Strategy
        public void SetStrategy(StrategySaveData strategy)
        {
            strategySaveData = strategy;
        }

        public void ExecuteStrategy()
        {
            strategySaveData.Save(this);
        }

        #endregion

        #region Prototype

        public Order Clone(List<Food> OrderList)
        {
            return new Order(OrderList);
        }

        #endregion

        #region State

        public State state { get; set; }

        public void ChangeState(State state)
        {
            this.state = state;
        }

        #endregion

        #region Command



        public void Execute(Chef chef)
        {
            chef.Make();//המלצר הביא למטבח את ההזמנה והשף מתחיל להכין 
        }
        #endregion
    }
}


