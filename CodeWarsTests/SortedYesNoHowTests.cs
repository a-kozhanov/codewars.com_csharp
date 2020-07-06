using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SortedYesNoHowTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("yes, ascending", SortedYesNoHow.IsSortedAndHow(new[] {1, 2}));
            Assert.AreEqual("yes, descending", SortedYesNoHow.IsSortedAndHow(new[] {15, 7, 3, -8}));
            Assert.AreEqual("no", SortedYesNoHow.IsSortedAndHow(new[] {4, 2, 30}));
        }
    }
}