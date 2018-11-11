using System;
namespace desingpatterns.patterns.construction.Prototype
{
    public class Main
    {
        public void execute() 
        {
            EmptyDocumentation emptyDocumentation = EmptyDocumentation.GetInstance();

            emptyDocumentation.add(new RequestOrderDocument());
            emptyDocumentation.add(new RequestEnrollmentDocument());
            emptyDocumentation.add(new RequestCesionCertificationDocument());

            new ClientDocumentation("Sebastian De La Roche").print();
            new ClientDocumentation("Tatiana Quintero").print();

        }
    }
}
