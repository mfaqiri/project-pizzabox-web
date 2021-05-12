
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class LargeCrust : ACrust
  {
    public LargeCrust()
    {
      Name = "Large";
      Size = 14;
      Price = 9.99;
      Vegan = false;
      Veget = false;
    }
  }
}