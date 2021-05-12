using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sauces
{
  public class Alfredo : ASauce
  {
    public Alfredo()
    {
      Name = "Alfredo";
      Veget = true;
      Vegan = false;
      Price = 2.50;
    }
  }
}