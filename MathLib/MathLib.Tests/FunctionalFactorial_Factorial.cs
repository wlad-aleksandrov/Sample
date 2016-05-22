using System;
using Xunit;

namespace WA.Mathematics.Tests
{
    public  class FunctionalFactorial_Factorial
    {
        [Fact]
        public void On0Returns1()
        {
            var mathLib = new FunctionalFactorial();
            var result = mathLib.Factorial(0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void On1Returns1()
        {
            var mathLib = new FunctionalFactorial();
            var result = mathLib.Factorial(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void One2Returns2()
        {
            var mathLib = new FunctionalFactorial();
            var result = mathLib.Factorial(2);
            Assert.Equal(2, result);
        }

        [Fact]
        public void On3Returns6()
        {
            var mathLib = new FunctionalFactorial();
            var result = mathLib.Factorial(3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void On10Returns3628800()
        {
            var mathLib = new FunctionalFactorial();
            var result = mathLib.Factorial(10);
            Assert.Equal(3628800, result);
        }

        [Fact]
        public void OnMinus1ThrowsException()
        {
            var mathLib = new FunctionalFactorial();
            var exception = Assert.Throws<ArgumentException>(() => mathLib.Factorial(-1));
        }


        // test for long values (int64)
        [Fact]
        public void On13Returns6227020800()
        {
            var mathLib = new FunctionalFactorial();
            var result = mathLib.Factorial(13);
            Assert.Equal(6227020800, result);
        }
    }
}
