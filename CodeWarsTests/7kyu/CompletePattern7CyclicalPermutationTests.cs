using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern7CyclicalPermutationTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1234567\n2345671\n3456712\n4567123\n5671234\n6712345\n7123456",
                CompletePattern7CyclicalPermutation.Pattern(7));
            Assert.AreEqual("1", CompletePattern7CyclicalPermutation.Pattern(1));
            Assert.AreEqual("1234\n2341\n3412\n4123", CompletePattern7CyclicalPermutation.Pattern(4));
            Assert.AreEqual("", CompletePattern7CyclicalPermutation.Pattern(0));
            Assert.AreEqual("", CompletePattern7CyclicalPermutation.Pattern(-25));
        }
    }
}