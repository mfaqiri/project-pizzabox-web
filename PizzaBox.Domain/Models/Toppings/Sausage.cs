using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Sausage : ATopping
  {
    public Sausage()
    {
      Name = "Sausage";
      Veget = false;
      Vegan = false;
      Price = 1.50;
    }
  }
}