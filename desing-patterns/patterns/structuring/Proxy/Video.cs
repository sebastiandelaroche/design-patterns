using System;
namespace desingpatterns.patterns.structuring.Proxy
{
    public class Video : Animation
    {
        public void clic() { }

        public void draw()
        {
            Console.WriteLine("Show Video");
        }

        public void load()
        {
            Console.WriteLine("Load Video");
        }

        public void play()
        {
            Console.WriteLine("Play Video");
        }
    }
}
