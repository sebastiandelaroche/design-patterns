using System;
namespace desingpatterns.patterns.structuring.Bridge
{
    public abstract class EnrollmentForm
    {
        protected string content;
        protected ImplementForm implementation;

        public EnrollmentForm(ImplementForm implementForm)
        {
            this.implementation = implementForm;
        }

        public void visualize()
        {
            this.implementation.drawText( "Enrollment number: ");
        }

        public void generateDocument()
        {
            this.implementation.drawText("Enrollment request");
            this.implementation.drawText($"Enrollment number: {this.content}");
        }

        public bool manageZone()
        {
            this.content = this.implementation.manageZone();
            return this.controlZone(this.content);
        }

        protected abstract bool controlZone(string enrollment);

    }
}
