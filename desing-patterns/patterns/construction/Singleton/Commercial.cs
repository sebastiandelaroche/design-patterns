using System;
namespace desingpatterns.patterns.construction.Singleton
{
    public class Commercial
    {
        static private Commercial _instance;

        static public Commercial GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Commercial();
            }

            return _instance;
        }

        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }

        private Commercial() { }

        public void visualize()
        {
            Console.WriteLine($"Name: {this.name}/nAddress: {this.address}/nEmail: {this.email}");
        }
    }
}
