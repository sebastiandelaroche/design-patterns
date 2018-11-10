using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public abstract class MotorBike
    {
        protected String color;
        protected Double price;
        protected String brand;

        public MotorBike(String color, Double price, String brand)
        {
            this.color = color;
            this.price = price;
            this.brand = brand;
        }

        abstract public void showInfo();
    }
}
