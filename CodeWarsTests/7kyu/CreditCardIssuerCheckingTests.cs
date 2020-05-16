using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CreditCardIssuerCheckingTests
    {
        [TestCase(4111111111111111, "VISA")]
        [TestCase(6011111111111117, "Discover")]
        [TestCase(9111111111111111, "Unknown")]
        public void SampleTests(long input, string result)
        {
            Assert.That(CreditCardIssuerChecking.getIssuer(input), Is.EqualTo(result));
        }
    }
}