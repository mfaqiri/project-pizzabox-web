using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Chedder : ATopping
  {
    public Chedder()
    {
      Name = "Chedder";
      Veget = true;
      Vegan = false;
      Price = 0.50;
    }
  }
}