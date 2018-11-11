using System;
namespace desingpatterns.patterns.construction.MethodFactory
{
    public class CreditOrder: Order
    {
        public CreditOrder(double amount) : base(amount) { }


        public override void payment()
        {
            Console.WriteLine($"The payment of the credit order by value of " +
                              $"{this.amount} has been done succesfully.");
        }

        public override void noPayment()
        {
            Console.WriteLine($"The payment of the credit order by value of " +
                              $"{this.amount} has been canceled because the amount " +
                              "broke the rules.");
        }

        public override bool validate()
        {
            return this.amount >= 1000 && this.amount <= 5000;
        }
    }
}
