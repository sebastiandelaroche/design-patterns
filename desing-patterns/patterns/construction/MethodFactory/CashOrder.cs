using System;
namespace desingpatterns.patterns.construction.MethodFactory
{
    public class CashOrder: Order
    {
        public CashOrder(double amount): base(amount) { }

        public override void payment()
        {
            Console.WriteLine($"The payment of the cash order by value of " +
                              $"{this.amount} has been done succesfully.");
        }

        public override void noPayment()
        {
            Console.WriteLine($"The payment of the cash order by value of " +
                              $"{this.amount} hasn't been canceled becase the amount" +
                              "broke wih the rules.");
        }

        public override bool validate()
        {
            return true;
        }
    }
}
