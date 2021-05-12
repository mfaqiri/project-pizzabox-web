using Xunit;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models.PizzaTypes;
using PizzaBox.Domain.Models.Crusts;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_ChicagoStore()
        {
            //arrange
            var sut = new ChicagoStore();

            //act
            var actual = sut.Name;

            //assert
            Assert.True(actual == "ChicagoStore");
        }


        [Fact]
        public void Test_NewYorkStore()
        {
            //arrange
            var sut = new NewYorkStore();

            //act

            //assert
            Assert.True(sut.Name.Equals("NewYorkStore"));
        }

        
    }
}