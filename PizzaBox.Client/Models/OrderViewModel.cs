using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Orders;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;


namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public List<AStore> Stores {get; set;}
    public List<Customer> Customers {get; set;}
    public List<ACrust> Crusts {get; set;}
    public List<ASauce> Sauces {get;set;}
    public List<APizzaType> PizzaTypes{get;set;}
    public List<ATopping> Toppings {get; set;}

    [Required(ErrorMessage = "please select a Customer")]
    [DataType(DataType.Text)]
    public string SelectedCustomer {get;set;}

    [Required(ErrorMessage = "please select a Store")]
    [DataType(DataType.Text)]
    public string SelectedStore {get;set;}

    [Required(ErrorMessage = "please select a crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust {get;set;}

    [Required(ErrorMessage = "please select a size")]
    [DataType(DataType.Text)]
    public string SelectedSauce {get;set;}

    [Required(ErrorMessage = "please select a pizza type")]
    [DataType(DataType.Text)]
    public string SelectedPizzaType {get;set;}

    [Required(ErrorMessage = "please select toppings")]
    public List<string> SelectedToppings{get;set;}




  public void Populate(UnitOfWork unitOfWork)
  {
    Customers = unitOfWork.Customers.Customers;
    Stores = unitOfWork.Stores.Stores;
    Crusts = unitOfWork.Crusts.Crusts;
    Sauces = unitOfWork.Sauces.Sauces;
    PizzaTypes = unitOfWork.Pizzas.pizzas;
    Toppings = unitOfWork.Toppings.toppings;
  }

  public IEnumerable<ValidationResult> ValidationResults(ValidationContext validationContext)
  {
    if(SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
    {
      yield return new ValidationResult("please select at least 2, but no more than 5 toppings", new[] { "SelectedToppings" });
    }
  }

  }
}