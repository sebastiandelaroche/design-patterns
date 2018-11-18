using System;
namespace desingpatterns.patterns.structuring.Decorator
{
    public class BrandDecorator: Decorator
    {
        public BrandDecorator(VehicleGraphicComponent component) : base(component) { }

        private void brandInformation()
        {
            Console.WriteLine("This the brand information");
        }

        public override void visualize()
        {
            base.visualize();
            this.brandInformation();
        }

    }
}
