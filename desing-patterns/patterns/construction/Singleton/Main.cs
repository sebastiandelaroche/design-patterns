using System;
namespace desingpatterns.patterns.construction.Singleton
{
    public class Main
    {
        public void execute()
        {
            Commercial commercial  = Commercial.GetInstance();
            commercial.name = "Sebastian De La Roche";
            commercial.address = "San Francisco - USA";
            commercial.email = "develop@addapptables.com";

            this.visualize();
        }

        void visualize()
        {
            Commercial.GetInstance().visualize();
        }
    }
}
