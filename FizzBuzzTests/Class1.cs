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


        public void NumbersReturnNumbersAsString()
        {
            //arrange
            var underTest = new FizzBuzzTests.FizzBuzzEngine();

            //act:

            string answer = underTest.DoTheThing(1);

            //assert:

            Assert.Equal("1", answer);
        }

    }
}
