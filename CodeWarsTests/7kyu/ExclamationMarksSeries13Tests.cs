using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries13Tests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(0, ExclamationMarksSeries13.Product(""));
            Assert.AreEqual(1, ExclamationMarksSeries13.Product("!?"));
            Assert.AreEqual(2, ExclamationMarksSeries13.Product("!??"));
            Assert.AreEqual(2, ExclamationMarksSeries13.Product("!!?"));
            Assert.AreEqual(6, ExclamationMarksSeries13.Product("!!???"));
            Assert.AreEqual(6, ExclamationMarksSeries13.Product("!!!??"));
            Assert.AreEqual(4, ExclamationMarksSeries13.Product("!!??"));
            Assert.AreEqual(4, ExclamationMarksSeries13.Product("!????"));
            Assert.AreEqual(4, ExclamationMarksSeries13.Product("!!!!?"));
            Assert.AreEqual(5, ExclamationMarksSeries13.Product("!?????"));
            Assert.AreEqual(20, ExclamationMarksSeries13.Product("!!????!!?"));
            Assert.AreEqual(49, ExclamationMarksSeries13.Product("!!???????!!!!!"));
            Assert.AreEqual(165, ExclamationMarksSeries13.Product("!!???????????!!!!!?!?!?!?!"));
            Assert.AreEqual(4, ExclamationMarksSeries13.Product("!!aabbcc??"));
            Assert.AreEqual(4, ExclamationMarksSeries13.Product("! !aa bb   c c??   "));
        }
    }
}