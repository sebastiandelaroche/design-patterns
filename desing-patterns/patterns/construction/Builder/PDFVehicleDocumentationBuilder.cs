using System;
namespace desingpatterns.patterns.construction.Builder
{
    public class PDFVehicleDocumentationBuilder: VehicleDocumentationBuilder
    {
        public PDFVehicleDocumentationBuilder()
        {
            this.documentation = new PDFDocumentation();
        }

        public override void buildOrderRequest(string customerName)
        {
            this.documentation.add($"<PDF> Customer Order Request: {customerName} </PDF>");
        }

        public override void buildEnrollmentRequest(string applicantName)
        {
            this.documentation.add($"<PDF> Applicant Enrollment Request: {applicantName} </PDF>");
        }
    }
}
