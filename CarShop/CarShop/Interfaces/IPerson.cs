using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
        public interface IPerson
        {
            string Name { get; }
            List<IOrder> Orders { get; set; }

            void Ordered(IStore store, IVehicle car);
            void Canceled(IStore store, IOrder order);
        }
    
}
