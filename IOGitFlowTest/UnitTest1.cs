using Xunit;
using IOGitFlow;

namespace IOGitFlowTest
{
    public class CalculatorTest
    {
        [Fact]
        public void addTest()
        {
            var calculator = new Calculator();

            Assert.Equal(5, calculator.add(2, 3));
        }

        [Fact]
        public void divideTest()
        {
            var calculator = new Calculator();

            Assert.Equal(2, calculator.divide(10, 5));
        }

        [Fact]
        public void divideByZeroTest()
        {
            var calculator = new Calculator();

            Assert.Equal(int.MaxValue, calculator.divide(10, 0));
        }
    }
}