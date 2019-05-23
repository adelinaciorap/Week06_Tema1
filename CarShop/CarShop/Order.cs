using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarShop
{
    public class Order : IOrder
    {
        public int ID { get; set; }
        public IStore Store { get; set; }
        public IPerson Customer { get; set; }
        public IVehicle Vehicle { get; set; }
        public int Delivery { get; set; }


        public Order(IPerson customer, IVehicle car, IStore shop, int delivery)
        {
            Customer = customer;
            Vehicle = car;
            Store = shop;
            Delivery = delivery;

        }
    }
}
