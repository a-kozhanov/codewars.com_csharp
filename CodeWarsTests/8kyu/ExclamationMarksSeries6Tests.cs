using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries6Tests
    {
        [Test, Description("It should work for basic tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Hi", ExclamationMarksSeries6.Remove("Hi!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeries6.Remove("Hi!", 100));
            Assert.AreEqual("Hi!!", ExclamationMarksSeries6.Remove("Hi!!!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeries6.Remove("Hi!!!", 100));
            Assert.AreEqual("Hi", ExclamationMarksSeries6.Remove("!Hi", 1));
            Assert.AreEqual("Hi!", ExclamationMarksSeries6.Remove("!Hi!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeries6.Remove("!Hi!", 100));
            Assert.AreEqual("!!Hi !!hi!!! !hi", ExclamationMarksSeries6.Remove("!!!Hi !!hi!!! !hi", 1));
            Assert.AreEqual("Hi !!hi!!! !hi", ExclamationMarksSeries6.Remove("!!!Hi !!hi!!! !hi", 3));
            Assert.AreEqual("Hi hi!!! !hi", ExclamationMarksSeries6.Remove("!!!Hi !!hi!!! !hi", 5));
            Assert.AreEqual("Hi hi hi", ExclamationMarksSeries6.Remove("!!!Hi !!hi!!! !hi", 100));
        }
    }
}