using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MakingSixToastTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(0, MakingSixToast.SixToast(6));
            Assert.AreEqual(11, MakingSixToast.SixToast(17));
            Assert.AreEqual(3, MakingSixToast.SixToast(3));
        }
    }
}