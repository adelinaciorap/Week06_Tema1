using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
        public interface IStore
        {
            string Name { get; set; }
            string City { get; set; }
            int Delivery { get; set; }
            List<IVehicle> Cars { get; set; }
            List<IOrder> Orders{ get; set; }
            void Sold(IVehicle car, IPerson client);
            void Canceled(IOrder car, IPerson client);
        }
    

}
