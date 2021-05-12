using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.PizzaTypes;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class PizzaTypeSingleton
  {
    private static PizzaTypeSingleton _instance;
    private readonly PizzaBoxContext _context;

    public List<APizzaType> pizzas { get; set; }
    public static PizzaTypeSingleton Instance(PizzaBoxContext context)
    {
        if (_instance == null)
        {
          _instance = new PizzaTypeSingleton(context);
        }

        return _instance;
    }

    /// <summary>
    /// 
    /// </summary>
    private PizzaTypeSingleton(PizzaBoxContext context)
    {
     _context = context;
    
    
     pizzas = _context.PizzaTypes.ToList();
     if(!pizzas.Any()){
      var csp = new CustomPizza();
      _context.Add(csp);
      _context.SaveChanges();

      
    }
    //pizzas = _context.PizzaTypes.ToList();
    }
  }
}
