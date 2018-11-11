using System;
namespace desingpatterns.patterns.construction.Builder
{
    public class HTMLDocumentation: Documentation
    {

        public override void add(string doc)
        {
            if (doc.StartsWith("<HTML>"))
            {
                this.content.Add(doc);
            }
        }

        public override void print()
        {
            Console.WriteLine("HTML Documentation");
            this.content.ForEach(Console.WriteLine);
        }
    }
}
