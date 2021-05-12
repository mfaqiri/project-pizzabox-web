using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Sauces;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models.PizzaTypes
{
  public class MeatloversPizza : APizzaType
  {

    public MeatloversPizza()
    {
      isCustom = false;
      Name = "Meat Lover's Pizza";
      predefinedToppings.Add("Marinara");
      predefinedToppings.Add("Sausage");

    }


  }
}