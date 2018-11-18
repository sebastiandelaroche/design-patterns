using System;
namespace desingpatterns.patterns.structuring.Decorator
{
    public class Main
    {
        public void execute()
        {
            VehicleView vehicle = new VehicleView();
            BrandDecorator decorator = new BrandDecorator(new ModelDecorator(vehicle));

            decorator.visualize();
        }
    }
}
