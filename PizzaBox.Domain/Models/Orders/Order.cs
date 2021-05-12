using System;
using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models.Orders
{
  public class Order : AModels
  {
    public double Price {get;set;}
    public List<Pizza> Pizzas;
    public Customer Customer;
    public AStore Store;
    public DateTime Time{get;set;}


    public Order()
    {
      Time = DateTime.Now;
      Price = 0.0;
      Pizzas = new List<Pizza>();
    }

    public bool NewOrder(Customer customer, AStore store)
        {
           bool timeLimit = true;
            foreach(Order parse in customer.orders)
            {
                TimeSpan delta = DateTime.Now - parse.Time;
                if(delta < new TimeSpan(2,0,0))
                {
                    timeLimit = false;
                }
            }
            if(timeLimit){
            Store = store;
            Price = 0.0;
            Store.orders.Add(this);
            Customer = customer;
            Customer.orders.Add(this);
           }
           return timeLimit;
        }

        public void CancelOrder()
        {
            Customer.orders.Remove(this);
        }

        public bool AddPizza(Pizza pizza)
        {
            
            Pizzas.Add(pizza);
            Price += pizza.Price;

            Price = Math.Round(Price, 2);
            return true;
        }

        public void RemovePizza(Pizza pizza)
        {
            Pizzas.Remove(pizza);
            Price -= pizza.Price;
        }

  }
}