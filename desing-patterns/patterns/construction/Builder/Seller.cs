using System;
namespace desingpatterns.patterns.construction.Builder
{
    public class Seller
    {
        protected VehicleDocumentationBuilder builder;

        public Seller(VehicleDocumentationBuilder builder)
        {
            this.builder = builder;
        }

        public Documentation build(string customerName)
        {
            this.builder.buildOrderRequest(customerName);
            this.builder.buildEnrollmentRequest(customerName);

            return this.builder.result();
        }
    }
}
