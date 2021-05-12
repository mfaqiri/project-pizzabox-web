using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Storing.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class ToppingSingleton
  {
    private static ToppingSingleton _instance;
    private readonly PizzaBoxContext _context;

    public List<ATopping> toppings { get; set; }
    public static ToppingSingleton Instance(PizzaBoxContext context)
    {
      
        if (_instance == null)
        {
          _instance = new ToppingSingleton(context);
        }

        return _instance;
    }

    /// <summary>
    /// 
    /// </summary>
    private ToppingSingleton(PizzaBoxContext context)
    {
      _context = context;
      // _context.Pizzas.AddRange(_fileRepository.ReadFromFile<List<APizza>>(_path));
//      var cp = new CustomPizza();

    toppings = _context.Toppings.ToList();

     if(!toppings.Any()){
      var c = new Chedder();
      var gc = new GrilledChicken();
      var p = new Parmesan();
      var pa = new Pineapple();
      var s = new Sausage();
      var sh = new Spinach();
      var m = new Mozzerella();
     _context.Add(c);
     _context.Add(gc);
     _context.Add(p);
     _context.Add(pa);
     _context.Add(s);
     _context.Add(sh);
     _context.Add(m);
     _context.SaveChanges();
      }
      //toppings = _context.Toppings.ToList();
    }
  }
}
