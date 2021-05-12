
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Orders;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var customer = _unitOfWork.Customers.Customers.Find(c => c.Name == order.SelectedCustomer);
        var store = _unitOfWork.Stores.Stores.Find(s => s.Name == order.SelectedStore);
        var crust = _unitOfWork.Crusts.Crusts.Find(c => c.Name == order.SelectedCrust);
        var sauce = _unitOfWork.Sauces.Sauces.Find(s => s.Name == order.SelectedSauce);
        var toppings = new ATopping[5];
        int index = 0;
        foreach (var item in order.SelectedToppings)
        {
          toppings[index] = _unitOfWork.Toppings.toppings.Find(t => t.Name == item);
          index++;
        }

        var newPizza = new Pizza();
        newPizza.Factory(crust, sauce, toppings);
        var newOrder = new Order();
        if(newOrder.NewOrder(customer,store))
        {
          newOrder.Store = store;
          newOrder.AddPizza(newPizza);
          _unitOfWork.Orders.Create(newOrder);

          _unitOfWork.Save();

           ViewBag.Order = newOrder;

          return View("checkout");
        }else
        {
          return View("InvalidOrder");
        }
      }

      order.Populate(_unitOfWork);

      return View("checkout");
    }
  }
}