using System;
namespace desingpatterns.patterns.structuring.Bridge
{
    public class HTMLImplementForm: ImplementForm
    {
        public void drawText(string text)
        {
            Console.WriteLine($"HTML: {text}");
        }

        public string manageZone()
        {
            return Console.ReadLine();
        }
    }
}
