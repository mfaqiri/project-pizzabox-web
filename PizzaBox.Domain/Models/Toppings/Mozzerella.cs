using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Mozzerella : ATopping
  {
    public Mozzerella()
    {
      Name = "Mozzerella";
      Veget = true;
      Vegan = false;
      Price = 0.50;
    }
  }
}