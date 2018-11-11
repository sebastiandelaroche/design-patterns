using System;
namespace desingpatterns.patterns.construction.MethodFactory
{
    public class CashClient: Client
    {

        protected override Order createOrder(double amount)
        {
            return new CashOrder(amount);
        }
    }
}
