using System;
namespace desingpatterns.patterns.structuring.Proxy
{
    public class AnimationProxy: Animation
    {
        protected Video video = null;
        protected string photo = "Show photo";

        public void clic()
        {
            if (video == null)
            {
                video = new Video();
                video.load();
            }

            video.play();
        }

        public void draw()
        {
            if (video != null)
            {
                video.draw();
            }
            else 
            {
                draw(photo);
            }
        }

        public void draw(string photo)
        {
            Console.WriteLine(photo);
        }
    }
}
