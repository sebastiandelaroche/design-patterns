using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.construction.MethodFactory
{
    public abstract class Client
    {
        protected List<Order> orders = new List<Order>();

        protected abstract Order createOrder(double amount);

        public void newOrder(double amount)
        {
            Order order = this.createOrder(amount);
            if (order.validate()) 
            {
                order.payment();
                orders.Add(order);
            } 
            else 
            {
                order.noPayment();
            }
        }
    }
}
