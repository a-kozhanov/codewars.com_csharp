using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleStringDivisionTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(23, SimpleStringDivision.solve("123", 1));
            Assert.AreEqual(234, SimpleStringDivision.solve("1234", 1));
            Assert.AreEqual(34, SimpleStringDivision.solve("1234", 2));
            Assert.AreEqual(4, SimpleStringDivision.solve("1234", 3));
        }
    }
}