using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public class ElectricityCar: Car
    {
        public ElectricityCar(String color, Double price, String brand) : base(color, price, brand) { }

        public override void showInfo()
        {
            Console.WriteLine($"The electricity car has the next info:\n " +
                              $"Color: {this.color}\n " +
                              $"Price: {this.price.ToString()}\n " +
                              $"Brand: {this.brand}");
        }

    }
}
