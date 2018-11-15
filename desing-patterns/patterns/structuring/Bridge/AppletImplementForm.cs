using System;
namespace desingpatterns.patterns.structuring.Bridge
{
    public class AppletImplementForm: ImplementForm
    {
        public void drawText(string text)
        {
            Console.WriteLine($"APPLET: {text}");
        }

        public string manageZone()
        {
            return Console.ReadLine();
        }
    }
}
