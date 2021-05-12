using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models.Orders
{
  public class Customer : AModels
  {
    public List<Order> orders;
    public string Name{get;set;}

    public Customer(string name)
    {
      Name = name;
      orders = new List<Order>();
    }

  }
}
