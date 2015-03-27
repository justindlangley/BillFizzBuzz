using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzTests
{
    public class Class1
    {
        [Fact]

        private FizzBuzzEngine underTest = 
        new FizzBuzzEngine();

        public void NumbersReturnNumbersAsString()
        {
            //arrange

            //act:

            string answer = underTest.DoTheThing(1);

            //assert:

            Assert.Equal("1", answer);
        }
    [Fact]
        public void NumbersDivisibleByThreeReturnFizz()
        {
            

            string answer = underTest.DoTheThing(3);

            Assert.Equal("Fizz", answer);

        }
        [Fact]
        public void NumbersDivisbleByFive()
    {

        string answer = underTest.DoTheThing(5);
        Assert.Equal("Buzz", answer);
        }

        [Fact]
        public void NumbersDivisibleByThreeAndFive()
        {
            string answer = underTest.DoTheThing(3 && 5);

            Assert.Equal("FizzBuzz", answer);

        }
    }
}

