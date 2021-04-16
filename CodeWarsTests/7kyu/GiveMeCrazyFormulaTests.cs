using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GiveMeCrazyFormulaTests
    {
        [Test]
        public void CheckFormula()
        {
            GiveMeCrazyFormula crazy = new GiveMeCrazyFormula();
            Assert.AreEqual(5, crazy.CrazyFormula(214));
            Assert.AreEqual(0, crazy.CrazyFormula(224));
            Assert.AreEqual(2, crazy.CrazyFormula(2224));
            Assert.AreEqual(9, crazy.CrazyFormula(2234));
            Assert.AreEqual(8, crazy.CrazyFormula(77633658797932970));
            Assert.AreEqual(6, crazy.CrazyFormula(7852));
        }
    }
}