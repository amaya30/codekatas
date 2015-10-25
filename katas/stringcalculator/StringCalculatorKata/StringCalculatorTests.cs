using System.Threading;

namespace StringCalculatorKata
{
    using NUnit.Framework;

    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Sum_EmptyString_ReturnsZero()
        {
            var stringCalc = new StringCalculator();
            Assert.AreEqual(0, stringCalc.Add(""));
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Sum_SingleNumber_ReturnsThatNumber(string numbers, int expected)
        {
            var stringCalc = new StringCalculator();
            Assert.AreEqual(expected, stringCalc.Add(numbers));
        }

        [TestCase("1,2", 3)]
        [TestCase("3,4", 7)]
        public void Sum_MultipleNumbers_ReturnsSumOfNumbers(string numbers, int expected)
        {
            var stringCalc = new StringCalculator();
            Assert.AreEqual(expected, stringCalc.Add(numbers));
        }

        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4", 10)]
        public void Sum_UnknownNumberOfNumbers_ReturnsSumOfNumbers(string numbers, int expected)
        {
            var stringCalc = new StringCalculator();
            Assert.AreEqual(expected, stringCalc.Add(numbers));
        }

        [Test]
        public void Sum_NewLineDelimiter_ReturnsSumOfNumbers()
        {
            var stringCalc = new StringCalculator();
            Assert.AreEqual(3, stringCalc.Add("1\n2"));
        }
    }
}
