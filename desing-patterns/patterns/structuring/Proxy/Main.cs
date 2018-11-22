using System;
namespace desingpatterns.patterns.structuring.Proxy
{
    public class Main
    {
        public void execute()
        {
            AnimationProxy proxy = new AnimationProxy();

            proxy.draw();
            proxy.clic();
            proxy.draw();
        }
    }
}
