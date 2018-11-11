using System;
namespace desingpatterns.patterns.construction.Prototype
{
    public class RequestEnrollmentDocument: Document
    {
        public override void print()
        {
            Console.WriteLine($"Print Request Enrollment: {this.content}");
        }

        public override void visualize()
        {
            Console.WriteLine($"Visuaize Request Enrollment: {this.content}");
        }
    }
}
