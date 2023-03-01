using Lektion6CICDexample;

namespace Lektion6CICDexampleTest
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            int a = 4;
            int b = 5;
            int expected = 9;
            Calculator calculator = new Calculator();

            int actual = calculator.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractTest()
        {
            int a = 4;
            int b = 5;
            int expected = -1;
            Calculator calculator = new Calculator();

            int actual = calculator.Subtract(a, b);

            Assert.Equal(expected, actual);
        }
    }
}