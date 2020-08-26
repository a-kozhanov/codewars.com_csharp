using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CaseSwappingTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("hELLOwORLD", CaseSwapping.Swap("HelloWorld"));
            Assert.AreEqual("cODEwARS", CaseSwapping.Swap("CodeWars"));
        }
    }
}