using System;
namespace desingpatterns.patterns.construction.Prototype
{
    public class RequestCesionCertificationDocument: Document
    {
        public override void print()
        {
            Console.WriteLine($"Print Request Cesion Certification: {this.content}");
        }

        public override void visualize()
        {
            Console.WriteLine($"Visuaize Request Cesion Certification: {this.content}");
        }
    }
}
