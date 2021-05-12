using Xunit;
using PizzaBox.Domain.Models.PizzaTypes;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTests
    {
       


        [Fact]
        public void Test_CustomPizza()
        {
            //arrange
            var sut = new CustomPizza();

            //act

            //assert
            Assert.True(sut.Name.Equals("Custom Pizza"));
        }

       
    }
}