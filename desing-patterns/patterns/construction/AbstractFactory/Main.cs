using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.construction.AbstractFactory
{
    public class Main
    {
        public void execute() {

            List<Car> cars = new List<Car>();
            List<MotorBike> motorBikes = new List<MotorBike>();

            cars.Add(new ElectricityVehicleFactory().createCar("Red", 10000, "BMW"));
            motorBikes.Add(new ElectricityVehicleFactory().createMotorBike("Red", 1000, "mountaint bike"));

            cars.Add(new GasolineVehicleFactory().createCar("Red", 70000, "BMW"));
            motorBikes.Add(new GasolineVehicleFactory().createMotorBike("Red", 500, "mountaint bike"));


            cars.ForEach((Car car) =>
            {
                car.showInfo();
            });

            motorBikes.ForEach((MotorBike motorBike) =>
            {
                motorBike.showInfo();
            });

        }
    }
}
