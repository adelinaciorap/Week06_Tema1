using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
        public interface IOrder
        {
            int ID{ get; set; }
            IPerson Customer { get; set; }
            IVehicle Vehicle { get; set; }
            IStore Store { get; set; }
            int Delivery { get; set; }

        
        }
    
}
