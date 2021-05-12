using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class XLargeCrust : ACrust
  {
    public XLargeCrust()
    {
      Name = "XLarge";
      Size = 18;
      Price = 11.99;
      Vegan = false;
      Veget = false;
    }
  }
}