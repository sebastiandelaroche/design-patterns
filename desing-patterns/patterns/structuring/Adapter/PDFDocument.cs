using System;
namespace desingpatterns.patterns.structuring.Adapter
{
    public class PDFDocument: Document
    {
        protected PDFComponent pdfComponent = new PDFComponent();

        public string content 
        { 
            set 
            {
                this.pdfComponent.setContent(value);
            }
        }

        public void draw()
        {
            this.pdfComponent.startVisualize();
            this.pdfComponent.refresh();
            this.pdfComponent.finishVisualize();
        }

        public void print()
        {
            this.pdfComponent.sendPrinter();
        }
    }
}
