using System.Collections.Generic;

namespace CarShop
{
    public class CarShop : IStore
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<IVehicle> Cars { get; set; }
        public List<IOrder> Orders{ get; set; } = new List<IOrder>();
        public int Delivery { get; set; }

        private int PreviousOrder = 0;

        public CarShop(string name, string city, List<IVehicle> cars, int delivery)
        {
            Name = name;
            City = city;
            Cars = cars;
            Delivery = delivery;

        }
            public void Sold(IVehicle vehicle, IPerson customer)
            {
                if (Cars.Exists(c => c.Manufacturer == vehicle.Manufacturer && c.Model == vehicle.Model))
                {
                    IOrder order = new Order(customer, vehicle, this, Delivery);
                    order.ID = ++PreviousOrder;
                    order.Vehicle = Cars.Find(c => c.Manufacturer == vehicle.Manufacturer && c.Model == vehicle.Model);
                    Orders.Add(order);
                    customer.Orders.Add(order);
                }
            }

            public void Canceled(IOrder order, IPerson customer)
            {
                if (Orders.Exists(o => o.ID == order.ID))
                {
                    Orders.Remove(Orders.Find(o => o.ID == order.ID));
                    customer.Orders.Remove(customer.Orders.Find(o => o.Store == order.Store && o.ID == order.ID));
                }
            }

    }

    
}