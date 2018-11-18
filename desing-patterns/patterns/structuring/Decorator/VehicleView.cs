using System;
namespace desingpatterns.patterns.structuring.Decorator
{
    public class VehicleView: VehicleGraphicComponent
    {
        public void visualize()
        {
            Console.WriteLine("Vehicle Visialuze");
        }
    }
}
