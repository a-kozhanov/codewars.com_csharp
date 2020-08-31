using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountSmileyFacesTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(4, CountSmileyFaces.CountSmileys(new string[] {":D", ":~)", ";~D", ":)"}));
            Assert.AreEqual(2, CountSmileyFaces.CountSmileys(new string[] {":)", ":(", ":D", ":O", ":;"}));
            Assert.AreEqual(1, CountSmileyFaces.CountSmileys(new string[] {";]", ":[", ";*", ":$", ";-D"}));
            Assert.AreEqual(0, CountSmileyFaces.CountSmileys(new string[] {";", ")", ";*", ":$", "8-D"}));
        }
    }
}