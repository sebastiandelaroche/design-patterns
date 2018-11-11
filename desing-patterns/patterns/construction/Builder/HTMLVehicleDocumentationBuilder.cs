using System;
namespace desingpatterns.patterns.construction.Builder
{
    public class HTMLVehicleDocumentationBuilder : VehicleDocumentationBuilder
    {

        public HTMLVehicleDocumentationBuilder()
        {
            this.documentation = new HTMLDocumentation();
        }

        public override void buildOrderRequest(string customerName)
        {
            this.documentation.add($"<HTML> Customer Order Request: {customerName} </HTML>");
        }

        public override void buildEnrollmentRequest(string applicantName)
        {
            this.documentation.add($"<HTML> Applicant Enrollment Request: {applicantName} </HTML>");
        }

    }
}
