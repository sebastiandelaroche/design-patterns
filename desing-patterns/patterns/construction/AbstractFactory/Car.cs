using System;
namespace desingpatterns.patterns.construction.AbstractFactory
{
    public abstract class Car
    {
        protected String color;
        protected Double price;
        protected String brand;

        public Car(String color, Double price, String brand)
        {
            this.color = color;
            this.price = price;
            this.brand = brand;
        }

        abstract public void showInfo();

    }
}
