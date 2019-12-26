using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun1SeatsInTheaterTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(96, SimpleFun1SeatsInTheater.SeatsInTheater(16, 11, 5, 3));

            Assert.AreEqual(0, SimpleFun1SeatsInTheater.SeatsInTheater(1, 1, 1, 1));

            Assert.AreEqual(18, SimpleFun1SeatsInTheater.SeatsInTheater(13, 6, 8, 3));

            Assert.AreEqual(99, SimpleFun1SeatsInTheater.SeatsInTheater(60, 100, 60, 1));

            Assert.AreEqual(0, SimpleFun1SeatsInTheater.SeatsInTheater(1000, 1000, 1000, 1000));
        }
    }
}