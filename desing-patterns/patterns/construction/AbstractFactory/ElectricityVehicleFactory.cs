using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public class ElectricityVehicleFactory: IVehicleFactory
    {
    

        public Car createCar(String color, Double price, String brand)
        {
            return new ElectricityCar(color, price, brand);
        }


        public MotorBike createMotorBike(String color, Double price, String brand)
        {
            return new ElectricityMotorBike(color, price, brand);
        }

    }
}
