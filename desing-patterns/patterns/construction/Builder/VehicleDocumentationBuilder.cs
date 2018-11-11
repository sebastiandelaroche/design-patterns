using System;
namespace desingpatterns.patterns.construction.Builder
{
    public abstract class VehicleDocumentationBuilder
    {
        protected Documentation documentation;

        public abstract void buildOrderRequest(string customerName);
        public abstract void buildEnrollmentRequest(string applicantName);

        public Documentation result()
        {
            return this.documentation;
        }
    }
}
