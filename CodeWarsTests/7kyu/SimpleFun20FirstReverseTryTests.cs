using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun20FirstReverseTryTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun20FirstReverseTry();

            Assert.AreEqual(new int[] {5, 2, 3, 4, 1}, kata.FirstReverseTry(new int[] {1, 2, 3, 4, 5}));

            Assert.AreEqual(new int[] { }, kata.FirstReverseTry(new int[] { }));

            Assert.AreEqual(new int[] {111}, kata.FirstReverseTry(new int[] {111}));

            Assert.AreEqual(new int[] {324, 54, 12, 3, 4, 56, 23, 12, 5, 23},
                kata.FirstReverseTry(new int[] {23, 54, 12, 3, 4, 56, 23, 12, 5, 324}));
        }
    }
}