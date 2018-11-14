using System;
namespace desingpatterns.patterns.structuring.Adapter
{
    public class PDFComponent
    {
        protected string content;

        public void setContent(string content)
        {
            this.content = content;
        }

        public void startVisualize()
        {
            Console.WriteLine("Visualize PDF: Start");
        }

        public void refresh()
        {
            Console.WriteLine($"Visualize content PDF: {this.content}");
        }

        public void finishVisualize()
        {
            Console.WriteLine("Visualize PDF: Finish");
        }

        public void sendPrinter()
        {
            Console.WriteLine($"Print PDF: {this.content}");
        }
    }
}
