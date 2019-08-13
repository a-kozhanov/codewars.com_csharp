using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeriesTests
    {
        [Test, Description("It should work for basic tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Hi", ExclamationMarksSeries.Remove("Hi!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeries.Remove("Hi!", 100));
            Assert.AreEqual("Hi!!", ExclamationMarksSeries.Remove("Hi!!!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeries.Remove("Hi!!!", 100));
            Assert.AreEqual("Hi", ExclamationMarksSeries.Remove("!Hi", 1));
            Assert.AreEqual("Hi!", ExclamationMarksSeries.Remove("!Hi!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeries.Remove("!Hi!", 100));
            Assert.AreEqual("!!Hi !!hi!!! !hi", ExclamationMarksSeries.Remove("!!!Hi !!hi!!! !hi", 1));
            Assert.AreEqual("Hi !!hi!!! !hi", ExclamationMarksSeries.Remove("!!!Hi !!hi!!! !hi", 3));
            Assert.AreEqual("Hi hi!!! !hi", ExclamationMarksSeries.Remove("!!!Hi !!hi!!! !hi", 5));
            Assert.AreEqual("Hi hi hi", ExclamationMarksSeries.Remove("!!!Hi !!hi!!! !hi", 100));
        }
    }
}