using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleStringReversalTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("srawedoc", SimpleStringReversal.solve("codewars"));
            Assert.AreEqual("edoc ruoy", SimpleStringReversal.solve("your code"));
            Assert.AreEqual("skco redo cruoy", SimpleStringReversal.solve("your code rocks"));
        }
    }
}