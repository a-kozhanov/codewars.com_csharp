using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetInitialsFromPersonNameTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(GetInitialsFromPersonName.toInitials("Kerry King"), "K. K.");
            Assert.AreEqual(GetInitialsFromPersonName.toInitials("Tom Araya"), "T. A.");
        }
    }
}