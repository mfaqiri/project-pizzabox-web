using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sauces
{
  public class Marinara : ASauce
  {
    public Marinara()
    {
      Name = "Marinara";
      Veget = true;
      Vegan = true;
      Price = 2.50;
    }
  }
}