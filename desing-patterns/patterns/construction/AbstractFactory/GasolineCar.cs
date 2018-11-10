using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public class GasolineCar: Car
    {
        public GasolineCar(String color, Double price, String brand) : base(color, price, brand) { }

        public override void showInfo()
        {
            Console.WriteLine($"The gasoline car has the next info:\n " +
                              $"Color: {this.color}\n " +
                              $"Price: {this.price.ToString()}\n " +
                              $"Brand: {this.brand}");
        }

    }
}
