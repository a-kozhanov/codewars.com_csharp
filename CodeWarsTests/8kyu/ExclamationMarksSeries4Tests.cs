using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries4Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Hi!", ExclamationMarksSeries4.Remove("Hi!"));
            Assert.AreEqual("Hi!", ExclamationMarksSeries4.Remove("Hi!!!"));
            Assert.AreEqual("Hi!", ExclamationMarksSeries4.Remove("!Hi"));
            Assert.AreEqual("Hi!", ExclamationMarksSeries4.Remove("!Hi!"));
            Assert.AreEqual("Hi Hi!", ExclamationMarksSeries4.Remove("Hi! Hi!"));
            Assert.AreEqual("Hi!", ExclamationMarksSeries4.Remove("Hi"));
        }
    }
}