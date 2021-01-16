using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsValidIdentifierTests
    {
        [Test]
        public void TestValid()
        {
            Assert.IsTrue(IsValidIdentifier.IsValid("i1"), "IsValid(\"i1\") should returns true");
        }

        [Test]
        public void TestInvalid()
        {
            Assert.IsFalse(IsValidIdentifier.IsValid("1i"), "IsValid(\"1i\") should returns false");
        }
    }
}