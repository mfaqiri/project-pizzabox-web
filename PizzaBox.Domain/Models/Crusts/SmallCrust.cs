using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class SmallCrust : ACrust
  {
    public SmallCrust()
    {
      Name = "Small";
      Size = 8;
      Price = 5.99;
      Vegan = false;
      Veget = false;
    }
  }
}