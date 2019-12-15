using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PoleVaultStartingMarksTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(9.45, PoleVaultStartingMarks.StartingMark(1.52));
            Assert.AreEqual(10.67, PoleVaultStartingMarks.StartingMark(1.83));
            Assert.AreEqual(8.27, PoleVaultStartingMarks.StartingMark(1.22));
            Assert.AreEqual(11.85, PoleVaultStartingMarks.StartingMark(2.13));
        }
    }
}