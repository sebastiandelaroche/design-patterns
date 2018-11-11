using System;
namespace desingpatterns.patterns.construction.Builder
{
    public class PDFDocumentation : Documentation
    {
        public override void add(string doc)
        {
            if (doc.StartsWith("<PDF>")) 
            {
                this.content.Add(doc);
            }
        }

        public override void print()
        {
            Console.WriteLine("PDF Documentation");
            this.content.ForEach(Console.WriteLine);
        }
    }
}
