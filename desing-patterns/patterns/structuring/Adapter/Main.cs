using System;
namespace desingpatterns.patterns.structuring.Adapter
{
    public class Main
    {
        public void execute()
        {
            Document htmlDocument, pdfDocument;

            htmlDocument = new HTMLDocument();
            htmlDocument.content = "This is a HTML document!";
            htmlDocument.draw();

            Console.WriteLine("----------------------------");

            pdfDocument = new PDFDocument();
            pdfDocument.content = "This is a PDF document!";
            pdfDocument.draw();
        }
    }
}
