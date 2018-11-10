using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public interface IVehicleFactory
    {
        Car createCar(String color, Double price, String brand);

        MotorBike createMotorBike(String color, Double price, String brand);

    }
}
