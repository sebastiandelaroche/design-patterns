using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.construction.Prototype
{
    public class ClientDocumentation: Documentation
    {
        public ClientDocumentation(string info)
        {
            this.documents = new List<Document>();
            EmptyDocumentation emptyDocumentation = EmptyDocumentation.GetInstance();


            emptyDocumentation.documents.ForEach((Document document) => {
                Document documentCloned = document.clone();
                documentCloned.fill(info);
                this.documents.Add(documentCloned);
            });
        }

        public void visualize() 
        {
            Console.WriteLine("Visualize client documents");
            this.documents.ForEach((Document document) => {
                document.print();
            });
        }

        public void print()
        {
            Console.WriteLine("Print client documents");
            this.documents.ForEach((Document document) => {
                document.print();
            });
        }

    }
}
