using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AbbreviateTwoWordNameTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("S.H", AbbreviateTwoWordName.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", AbbreviateTwoWordName.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", AbbreviateTwoWordName.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", AbbreviateTwoWordName.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", AbbreviateTwoWordName.AbbrevName("David Mendieta"));
        }
    }
}