using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FizzBuzzTest
{
    using FizzBuzz;

    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void DivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var answer = fizzBuzz.Answer(5);
            Assert.AreEqual(expected: "buzz", actual: answer);
        }

        [TestMethod]
        public void DivisibleByFive()
        {
            var fizzBuzz = new FizzBuzz();
            var answer = fizzBuzz.Answer(6);
            Assert.AreEqual(expected: "fizz", actual: answer);
        }

        [TestMethod]
        public void DivisibleByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzz();
            var answer = fizzBuzz.Answer(15);
            Assert.AreEqual(expected: "fizzbuzz", actual: answer);
        }

        [TestMethod]
        public void NotDivisbleByThreeOrFive()
        {
            var fizzBuzz = new FizzBuzz();
            var answer = fizzBuzz.Answer(4);
            Assert.AreEqual(expected: "4", actual: answer);
        }
    }

}
