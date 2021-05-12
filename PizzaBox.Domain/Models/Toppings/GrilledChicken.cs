using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class GrilledChicken : ATopping
  {
    public GrilledChicken()
    {
      Name = "GrilledChicken";
      Veget = false;
      Vegan = false;
      Price = 1.50;
    }
  }
}