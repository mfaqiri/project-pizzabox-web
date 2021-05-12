using Xunit;
using PizzaBox.Domain.Models.Orders;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.PizzaTypes;

namespace PizzaBox.Testing.Tests
{
    public class OrderTests
    {
        
        
        [Fact]
        public void Test_Order()
        {
            //arrange
            var sut = new Order();


            Assert.False(sut.Pizzas.Equals(null));
        }

        [Fact]
        public void Test_newOrder()
        {
            var order = new Order();
            var sut = order.Price;
            Assert.True(sut == 0.0);
        }

     

        [Fact]
        public void Test_hasPizza()
        {
            var pizza = new Pizza();
            var order = new Order();
            var store = new NewYorkStore();
            var customer = new Customer("new customer");
            order.NewOrder(customer, store);
            order.AddPizza(pizza);
            Assert.True(order.Pizzas.Contains(pizza));
        }

        [Fact]
        public void Test_hasPizzaPrice()
        {
            var pizza = new Pizza();
            var order = new Order();
            var store = new NewYorkStore();
            var customer = new Customer("new customer");
            order.NewOrder(customer, store);
            order.AddPizza(pizza);
            Assert.True(order.Price == pizza.Price);
        }

        [Fact]
        public void Test_notHavePizza()
        {
            var pizza = new Pizza();
            var order = new Order();
            var customer = new Customer("new customer");
            var store = new NewYorkStore();
            order.NewOrder(customer, store);
            order.AddPizza(pizza);
            order.RemovePizza(pizza);
            Assert.False(order.Pizzas.Contains(pizza));
        }
    }
}