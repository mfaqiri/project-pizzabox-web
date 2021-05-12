using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Parmesan : ATopping
  {
    public Parmesan()
    {
      Name = "Parmesan";
      Veget = true;
      Vegan = false;
      Price = 0.50;
    }
  }
}