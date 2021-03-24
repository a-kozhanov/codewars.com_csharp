using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FacRecursionTests
    {
        [Test]
        public void KataFacCalculationTest()
        {
            KataFacRecursion fac = new KataFacRecursion();

            Assert.AreEqual(1, fac.FacCalculation(1));

            Assert.AreEqual(6, fac.FacCalculation(3));
        }
    }
}