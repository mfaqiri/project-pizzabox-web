using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models.PizzaTypes
{
  public class CheesePizza : APizzaType
  {


    public CheesePizza()
    {
      isCustom = false;
      Name = "Cheese Pizza";
      predefinedToppings.Add("Mozzerella");
      predefinedToppings.Add("Marinara");
    }
  }
}