using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindStrayNumberTests
    {
        [Test]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, FindStrayNumber.Stray(new int[] {1, 1, 2}));
        }
    }
}