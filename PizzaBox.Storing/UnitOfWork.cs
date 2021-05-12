using PizzaBox.Storing.Repositories;
using PizzaBox.Storing.Singletons;


namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;

    public CustomerSingleton Customers {get;}
    public CrustSingleton Crusts{get;set;}
    public  OrderRepository Orders{get;set;}
    public PizzaTypeSingleton Pizzas { get; set; }
    public SauceSingleton Sauces { get; }
    public StoreSingleton Stores{get;}
    public ToppingSingleton Toppings { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Customers = CustomerSingleton.Instance(_context);
      Crusts = CrustSingleton.Instance(_context);
      Orders = new OrderRepository(_context);
      Pizzas = PizzaTypeSingleton.Instance(_context);
      Sauces = SauceSingleton.Instance(_context);
      Toppings = ToppingSingleton.Instance(_context);
      Stores = StoreSingleton.Instance(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}