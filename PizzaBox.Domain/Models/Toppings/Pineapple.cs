using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Pineapple : ATopping
  {
    public Pineapple()
    {
      Name = "Pineapple";
      Veget = true;
      Vegan = true;
      Price = 0.60;
    }
  }
}