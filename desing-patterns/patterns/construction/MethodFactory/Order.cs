using System;
namespace desingpatterns.patterns.construction.MethodFactory
{
    public abstract class Order
    {
        protected double amount;

        public Order(double amount)
        {
            this.amount = amount;
        }

        public abstract bool validate();
        public abstract void payment();
        public abstract void noPayment();
    }
}
