using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public class GasolineMotorBike: MotorBike
    {
        public GasolineMotorBike(String color, Double price, String brand) :base(color, price, brand) { }

        public override void showInfo()
        {
            Console.WriteLine($"The gasoline motorbike has the next info:\n " +
                              $"Color: {this.color}\n " +
                              $"Price: {this.price.ToString()}\n " +
                              $"Brand: {this.brand}");
        }

    }
}
