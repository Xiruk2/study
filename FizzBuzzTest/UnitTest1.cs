using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzSample;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
            var fizzBuzz = new FizzBuzz(15);
            var actual = fizzBuzz.GetFizzBuzz();

            // test
            Assert.AreEqual(expected, actual);
        }
    }
}
