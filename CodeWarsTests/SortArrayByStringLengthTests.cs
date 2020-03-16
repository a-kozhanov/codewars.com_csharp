using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SortArrayByStringLengthTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new string[] {"I", "To", "Beg", "Life"},
                SortArrayByStringLength.SortByLength(new string[] {"Beg", "Life", "I", "To"}));
            Assert.AreEqual(new string[] {"", "Pizza", "Brains", "Moderately"},
                SortArrayByStringLength.SortByLength(new string[] {"", "Moderately", "Brains", "Pizza"}));
            Assert.AreEqual(new string[] {"Short", "Longer", "Longest"},
                SortArrayByStringLength.SortByLength(new string[] {"Longer", "Longest", "Short"}));
        }
    }
}