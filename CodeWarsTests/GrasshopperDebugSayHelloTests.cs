using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperDebugSayHelloTests
    {
        [Test]
        [TestCase("Mr. Spock", ExpectedResult = "Hello, Mr. Spock")]
        [TestCase("Captain Kirk", ExpectedResult = "Hello, Captain Kirk")]
        [TestCase("Liutenant Uhura", ExpectedResult = "Hello, Liutenant Uhura")]
        [TestCase("Dr. McCoy", ExpectedResult = "Hello, Dr. McCoy")]
        public static string FixedTest(string name)
        {
            return GrasshopperDebugSayHello.SayHello(name);
        }
    }
}