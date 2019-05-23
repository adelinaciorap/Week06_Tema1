using System.Collections.Generic;

namespace CarShop
{
    class Customer : IPerson
    {
        public string Name { get; set; }
        public List<IOrder> Orders { get; set; } = new List<IOrder>();

        public Customer(string name)
        {
            this.Name = name;
        }
        public void Ordered(IStore shop, IVehicle car)
        {
            shop.Sold(car, this);
        }
        public void Canceled(IStore shop, IOrder order)
        {
            if (Orders.Exists(c => c.Store == order.Store && c.ID == order.ID))
            {
                shop.Canceled(order, this);
            }
        }

    }
}
