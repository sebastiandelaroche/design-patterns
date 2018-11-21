using System;
namespace desingpatterns.patterns.structuring.Flyweight
{
    public class VehicleOption
    {
        protected string name;
        protected string description;
        protected int standardPrice;

        public VehicleOption(string name)
        {
            this.name = name;
            this.description = $"Desciption for {name}";
            this.standardPrice = 100;
        }

        public void visualize(int salePrice)
        {
            Console.WriteLine("Option");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine(this.description);
            Console.WriteLine("Standard price: " + this.standardPrice);
            Console.WriteLine("Sale price: " + salePrice);
        }
    }
}
