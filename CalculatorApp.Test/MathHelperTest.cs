using System;
using Xunit;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var calculator = new MathFormulas();

            int x = 1;
            int y = 2;

            var xResult = calculator.IsEven(x);
            var yResult = calculator.IsEven(y);

            Assert.False(xResult);
            Assert.True(yResult);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 3, 2)]
        public void DiffTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Diff(x, y);
            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [InlineData(new int[3] {1 ,2, 3}, 6)]
        [InlineData(new int[3] { -4, -6, -10}, -20)]
        public void SumTest(int[] values, int expectedValue)
        {
            var calculatot = new MathFormulas();
            var result = calculatot.Sum(values);
            Assert.Equal(result, expectedValue);
        }
    }
}
