using System;
namespace desingpatterns.patterns.construction.MethodFactory
{
    public class Main
    {
        public void execute()
        {
            Client client;

            client = new CashClient();
            client.newOrder(1000);
            client.newOrder(10000);

            client = new CreditClient();
            client.newOrder(1000);
            client.newOrder(10000);
        }
    }
}
