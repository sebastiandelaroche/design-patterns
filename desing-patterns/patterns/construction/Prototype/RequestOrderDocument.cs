using System;
namespace desingpatterns.patterns.construction.Prototype
{
    public class RequestOrderDocument: Document
    {
        public override void print()
        {
            Console.WriteLine($"Print Request Order: {this.content}");
        }

        public override void visualize()
        {
            Console.WriteLine($"Visuaize Request Order: {this.content}");
        }
    }
}
