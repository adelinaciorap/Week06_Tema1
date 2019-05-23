using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Program
    {

        static void Main(string[] args)
        {
            IPerson Alex = new Customer("Alex");
            IVehicle FordFocus = new Car("Ford", "Focus", 2015);
            IVehicle SkodaFabia = new Car("Skoda", "Fabia", 2015);
            IStore FordStore = new CarShop("Ford Store", "Iasi",
            new List<IVehicle>() {
                    new Car("Ford", "Focus", 2015, 15000),
            }, 4);

            IStore SkodaStore = new CarShop("SkodaStore", "Pascani",
            new List<IVehicle>() {
                    new Car("Skoda", "Fabia", 2015, 15000),
            }, 3);

            Alex.Ordered(FordStore,FordFocus); 
            Console.WriteLine("Car ordered from Ford.");
            Alex.Ordered( SkodaStore, SkodaFabia);
            Console.WriteLine("Car ordered from Skoda.");
            Alex.Canceled(FordStore, Alex.Orders.Find(m => m.Vehicle.Model == FordFocus.Model));
            Console.WriteLine("Ford ordered cancelled.");
            Console.ReadKey();
        }

    }

    
}