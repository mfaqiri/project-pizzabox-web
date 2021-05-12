using Xunit;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Testing.Tests
{
    public class ToppingTests
    {
        [Fact]
        public void Test_Mozzerella()
        {
            //arrange
            var sut = new Mozzerella();

            //act
            var actual = sut.Name;

            //assert
            Assert.True(actual == "Mozzerella");
        }


         [Fact]
        public void Test_Chedder()
        {
            //arrange
            var sut = new Chedder();

            //act

            //assert
            Assert.True(sut.Name.Equals("Chedder"));
        }

         [Fact]
        public void Test_Spinach()
        {
            //arrange
            var sut = new Spinach();

            //act

            //assert
            Assert.True(sut.Name.Equals("Spinach"));
        }

      
         [Fact]
        public void Test_GrilledChicken()
        {
            //arrange
            var sut = new GrilledChicken();

            //act

            //assert
            Assert.True(sut.Name.Equals("GrilledChicken"));
        }

         [Fact]
        public void Test_Parmesan()
        {
            //arrange
            var sut = new Parmesan();

            //act

            //assert
            Assert.True(sut.Name.Equals("Parmesan"));
        }

       
         [Fact]
        public void Test_Sausage()
        {
            //arrange
            var sut = new Sausage();


            Assert.True(sut.Name.Equals("Sausage"));
        }

        

         [Fact]
        public void Test_Pineapple()
        {
            //arrange
            var sut = new Pineapple();

            //act

            //assert
            Assert.True(sut.Name.Equals("Pineapple"));
        }
    }
}