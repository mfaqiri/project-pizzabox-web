using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Crusts;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class CrustSingleton
  {
    private static CrustSingleton _instance;
    private readonly PizzaBoxContext _context;

    public List<ACrust> Crusts { get; set; }
    public static CrustSingleton Instance(PizzaBoxContext context)
    {
        if (_instance == null)
        {
          _instance = new CrustSingleton(context);
        }

        return _instance;
    }

    /// <summary>
    /// 
    /// </summary>
    private CrustSingleton(PizzaBoxContext context)
    {
    _context = context;

    Crusts = _context.Crusts.ToList();
    if(!Crusts.Any())
    {
      
     var m = new MediumCrust();
     var s = new SmallCrust();
     var l = new LargeCrust();
     var x = new XLargeCrust();
     _context.Add(m);
     _context.Add(s);
     _context.Add(l);
     _context.Add(x);
     _context.SaveChanges();
    }
    //Crusts = _context.Crusts.ToList();
  //    _context.Add(cp);
//      _context.SaveChanges();

//      Pizzas = _context.Pizzas.ToList();
    }
  }
}
