using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HeronsFormulaTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(6.0, HeronsFormula.heron(3, 4, 5));
        }
    }
}