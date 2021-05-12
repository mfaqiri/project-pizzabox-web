using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Spinach : ATopping
  {
    public Spinach()
    {
      Name = "Spinach";
      Veget = true;
      Vegan = true;
      Price = 0.50;
    }
  }
}