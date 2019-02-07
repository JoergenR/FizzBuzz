using System;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetFizzBuzz_InputIsDividableBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetFizzBuzz(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        
        [Test]
        public void GetFizzBuzz_InputIsDividableBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetFizzBuzz(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetFizzBuzz_InputIsDividableBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetFizzBuzz(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetFizzBuzz_InputIsNotDividableBy3Or5_ReturnSameNumber()
        {
            var result = FizzBuzz.GetFizzBuzz(1);

            Assert.That(result, Is.EqualTo("1"));
        }


    }
}
