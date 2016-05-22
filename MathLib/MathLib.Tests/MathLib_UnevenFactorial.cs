using System;
using Xunit;

namespace WA.Mathematics.Tests
{
    public class MathLib_UnevenFactorial
    {
        [Fact]
        public void On0ShouldReturn1()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void O1ShouldReturn1()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(1);
            Assert.Equal(1, result);
        }
        [Fact]
        public void On2ShouldReturn1()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void On3ShouldReturn3()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(3);
            Assert.Equal(3, result);
        }

        [Fact]
        public void On4ShouldReturn3()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(4);
            Assert.Equal(3, result);
        }

        [Fact]
        public void On5ShouldReturn15()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void On8ShouldReturn105()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(8);
            Assert.Equal(105, result);
        }

        [Fact]
        public void On9ShouldReturn945()
        {
            var mathLib = new MathLib();
            var result = mathLib.UnevenFactorial(9);
            Assert.Equal(945, result);
        }
        [Fact]
        public void OnMinus1ThrowsException()
        {
            var mathLib = new MathLib();
            var exception = Assert.Throws<ArgumentException>(() => mathLib.UnevenFactorial(-1));
        }
    }
}