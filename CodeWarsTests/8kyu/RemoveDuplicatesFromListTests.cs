using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveDuplicatesFromListTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new int[] { 1 }, RemoveDuplicatesFromList.distinct(new int[] { 1 }));
            Assert.AreEqual(new int[] { 1, 2 }, RemoveDuplicatesFromList.distinct(new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 1, 2 }, RemoveDuplicatesFromList.distinct(new int[] { 1, 1, 2 }));
        }
    }
}