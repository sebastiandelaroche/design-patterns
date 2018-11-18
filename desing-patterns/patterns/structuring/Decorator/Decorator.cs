using System;
namespace desingpatterns.patterns.structuring.Decorator
{
    public class Decorator: VehicleGraphicComponent
    {
        protected VehicleGraphicComponent component;

        public Decorator(VehicleGraphicComponent component)
        {
            this.component = component;
        }

        public virtual void visualize()
        {
            this.component.visualize();
        }
    }
}
