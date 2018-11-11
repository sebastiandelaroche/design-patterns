using System;
namespace desingpatterns.patterns.construction.MethodFactory
{
    public class CreditClient : Client
    {
        protected override Order createOrder(double amount)
        {
            return new CreditOrder(amount);
        }
    }
}
