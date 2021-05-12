using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class MediumCrust : ACrust
  {
    public MediumCrust()
    {
      Name = "Medium";
      Size = 10;
      Price = 7.99;
      Vegan = false;
      Veget = false;
    }
  }
}