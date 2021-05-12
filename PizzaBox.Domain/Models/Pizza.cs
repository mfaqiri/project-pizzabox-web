using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Orders;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Pizza : AModels
  {

    public Order order{get; set;}
    public APizzaType pizzaType {get;set;}
    public bool isCustom{get;}
    public ACrust Crust {get;private set;}
    public ASauce Sauce {get;private set;}
    public List<ATopping> Toppings = new List<ATopping>();

    public double Price{get; private set;}
    private const uint _toppingLimit = 5;


     public void Factory(ACrust crust, ASauce sauce, ATopping[] toppings)
    {
      AddSauce(sauce);
      AddCrust(crust);
      AddTopping(toppings);
    }


    public void AddPizzaType(APizzaType pizzaType)
    {
      this.pizzaType = pizzaType;

    }

   

    private void AddCrust(ACrust crust)
    {
      Crust = crust;
    }

    private void AddSauce(ASauce sauce)
    {
      Sauce = sauce;
    }

    private void AddTopping(params ATopping[] toppings)
    {
        foreach(var topping in toppings)
        {
            if(topping == null)
              break;
            Toppings.Add(topping);
            topping.pizza = this;
        }

    }

    private void CalcPrice()
    {
      Price = 0;
      Price += Sauce.Price;
      Price += Crust.Price;
      foreach(var topping in Toppings)
      {
        Price += topping.Price;
      }
      Price = Math.Round(Price,2);
    }

    public bool IsVegetarian()
    {
      foreach(var topping in Toppings)
      {
        if(!topping.Veget)
          return false;
      }

      return true;
    }

    public bool IsVegan()
    {
      foreach(var topping in Toppings)
      {
        if(!topping.Vegan)
          return false;
      }

      return true;
    }

    public void MakeVegetarian()
    {
      foreach(var topping in Toppings)
      {
        if(!topping.Veget)
        {
          RemoveTopping(topping);
        }
      }
    }

    public void MakeVegan()
    {
      foreach(var topping in Toppings)
      {
        if(!topping.Vegan)
        {
          RemoveTopping(topping);
        }
      }
    }

    private void RemoveTopping(ATopping topping)
    {
      Toppings.Remove(topping);
      Price -= topping.Price;
    }


  }

}