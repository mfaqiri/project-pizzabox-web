using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.PizzaTypes
{
  public class CustomPizza : APizzaType
  {
    
    public CustomPizza()
    {
      Name = "Custom Pizza";
      isCustom = true;
    }
  }
}