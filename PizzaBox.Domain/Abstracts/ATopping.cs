using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class ATopping : AIngrediant
  {
    public Pizza pizza{get;set;} 
  }
}