using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sauces
{
  public class Bbq : ASauce
  {
    public Bbq()
    {
      Name = "BBQ";
      Veget = false;
      Vegan = false;
      Price = 2.50;
    }
  }
}