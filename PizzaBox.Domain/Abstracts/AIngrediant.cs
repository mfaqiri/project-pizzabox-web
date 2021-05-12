
namespace PizzaBox.Domain.Abstracts
  

{
  public abstract class AIngrediant : AModels
  {
  public string Name{get;set;}
  public double Price{get; protected set;}
  public bool Vegan{get; protected set;}

  public bool Veget{get; protected set;}

  }

}