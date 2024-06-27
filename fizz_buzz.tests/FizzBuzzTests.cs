using Xunit.Sdk;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {

        //Multiple of 3 prints "Fizz"
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void GivenWhenMultipleOf3ThenReturnFizz(int number)
        {
            //Arrange
            string expected = "Fizz";
            //Act
            string actual = FizzBuzz.GetOutput(number);
            //Assert
            Assert.Equal(expected, actual);
        }


        //Multiple of 5 prints "Buzz"
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GivenWhenMultipleOf5ThenReturnBuzz(int number)
        {
            //arrange
            string expected = "Buzz";
            //act
            string actual = FizzBuzz.GetOutput(number);
            //assert
            Assert.Equal(expected, actual);
        }

        //Multiple of 3 and 5 print "FizzBuzz"
        [Theory]
        [InlineData(15)]
        public void GivenWhenMultipleOf3And5ThenReturnFizzBuzz(int number)
        {
            //arrange
            string expected = "FizzBuzz";
            //act
            string actual = FizzBuzz.GetOutput(number);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        public void GivenWhenNumberIsNotMultipleOf3Or5ThenReturnNumber(int number)
        { 
            //arrange
            string expected = number.ToString();
            //act
            string actual = FizzBuzz.GetOutput(number);
            //assert
            Assert.Equal(expected, actual);
        }


    }
}