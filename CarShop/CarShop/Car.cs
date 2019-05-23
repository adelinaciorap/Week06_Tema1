namespace CarShop
{
    public class Car : IVehicle
    {
        public Car(string manufacturer,string model, int year, double price)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public string Model { get; set; }
        public int Year{ get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }


        public Car(string manufacturer, string model, int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
            
        }
    }

}
