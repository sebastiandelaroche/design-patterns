using System;
namespace desingpatterns.patterns.structuring.Decorator
{
    public class ModelDecorator: Decorator
    {
        public ModelDecorator(VehicleGraphicComponent component) : base(component) { }

        private void tecnicalInformation() 
        {
            Console.WriteLine("This the tecnical information");
        }

        public override void visualize()
        {
            base.visualize();
            this.tecnicalInformation();
        }

    }
}
