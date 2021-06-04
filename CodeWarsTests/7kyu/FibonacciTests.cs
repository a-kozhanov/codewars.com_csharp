using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void MyTest()
            {
                Assert.AreEqual(5, Fibonacci.fib(5));
                Assert.AreEqual(55, Fibonacci.fib(10));
            }
        }
    }
}