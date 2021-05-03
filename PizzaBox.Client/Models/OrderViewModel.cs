namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public List<string> Crusts {get; set;}
    public List<string> Sauces {get;set;}
    public List<string> Toppings {get; set;}

    public string SelectedCrust {get;set;}
    public string SelectedSauce {get;set;}
    public List<string> SelectedToppings{get;set;}


  }
}