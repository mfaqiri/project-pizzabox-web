using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Orders;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models.PizzaTypes;
using PizzaBox.Domain.Models.Sauces;
using PizzaBox.Domain.Models.Crusts;
using PizzaBox.Domain.Models.Toppings;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<AStore> Stores {get; set;}
    public DbSet<APizzaType> PizzaTypes {get; set;}

    public DbSet<Pizza> Pizzas {get; set;}
    public DbSet<ACrust> Crusts {get;set;}
    public DbSet<ASauce> Sauces {get;set;}
    public DbSet<Customer> Customers {get;set;}
    public DbSet<ATopping> Toppings {get;set;}
    public DbSet<Order> orders {get;set;}

    public PizzaBoxContext(DbContextOptions options) : base(options) { } 
    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<Pizza>().HasKey(e => e.EntityId);

      builder.Entity<AStore>().HasKey(e => e.EntityId);
      builder.Entity<ChicagoStore>().HasBaseType<AStore>();
      builder.Entity<NewYorkStore>().HasBaseType<AStore>();

      builder.Entity<APizzaType>().HasKey(e => e.EntityId);
      builder.Entity<CustomPizza>().HasBaseType<APizzaType>();

      builder.Entity<ASauce>().HasKey(e => e.EntityId);
      builder.Entity<Alfredo>().HasBaseType<ASauce>();
      builder.Entity<Marinara>().HasBaseType<ASauce>();
      builder.Entity<Bbq>().HasBaseType<ASauce>();

      builder.Entity<ACrust>().HasKey(e => e.EntityId);
      builder.Entity<MediumCrust>().HasBaseType<ACrust>();
      builder.Entity<LargeCrust>().HasBaseType<ACrust>();
      builder.Entity<SmallCrust>().HasBaseType<ACrust>();
      builder.Entity<XLargeCrust>().HasBaseType<ACrust>();
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<ATopping>().HasKey(e => e.EntityId);
      builder.Entity<Sausage>().HasBaseType<ATopping>();
      builder.Entity<Chedder>().HasBaseType<ATopping>();
      builder.Entity<Mozzerella>().HasBaseType<ATopping>();
      builder.Entity<Parmesan>().HasBaseType<ATopping>();
      builder.Entity<GrilledChicken>().HasBaseType<ATopping>();
      builder.Entity<Pineapple>().HasBaseType<ATopping>();
      builder.Entity<Spinach>().HasBaseType<ATopping>();









      builder.Entity<Customer>().HasKey(e => e.EntityId);


      builder.Entity<AStore>().HasMany<Order>(s => s.orders).WithOne(o => o.Store);
      builder.Entity<Customer>().HasMany<Order>(c => c.orders).WithOne(o => o.Customer);
      builder.Entity<Order>().HasMany<Pizza>(o => o.Pizzas);
      builder.Entity<Pizza>().HasMany<ATopping>(p => p.Toppings);
      builder.Entity<Pizza>().HasOne<ASauce>(p => p.Sauce);
      builder.Entity<Pizza>().HasOne<ACrust>(p => p.Crust);
      builder.Entity<Pizza>().HasOne<APizzaType>(p => p.pizzaType);




    }
  }
}