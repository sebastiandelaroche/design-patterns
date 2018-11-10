using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public class GasolineVehicleFactory: IVehicleFactory
    {

        public Car createCar(String color, Double price, String brand)
        {
            return new GasolineCar(color, price, brand);
        }


        public MotorBike createMotorBike(String color, Double price, String brand)
        {
            return new GasolineMotorBike(color, price, brand);
        }

    }
}
