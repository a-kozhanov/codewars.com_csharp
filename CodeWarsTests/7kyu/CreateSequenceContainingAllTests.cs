using System.Text.RegularExpressions;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CreateSequenceContainingAllTests
    {
        [Test]
        public void _0_BasicTests()
        {
            var kata = new CreateSequenceContainingAll();

            Assert.AreEqual("abc", kata.CreateSequence(new Regex(@"[a-c]")));
            Assert.AreEqual("0123456789ABCDEF", kata.CreateSequence(new Regex(@"[0-9A-F]")));
        }
    }
}