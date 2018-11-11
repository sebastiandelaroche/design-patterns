using System;
namespace desingpatterns.patterns.construction.Builder
{
    public class Main
    {
        public void execute() 
        {
            new Seller(new HTMLVehicleDocumentationBuilder())
                .build("Sebastian De La Roche")
                .print();

            new Seller(new PDFVehicleDocumentationBuilder())
                .build("Sebastian De La Roche")
                .print();
        }
    }
}
