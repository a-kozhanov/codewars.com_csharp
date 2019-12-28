using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataSortGiftCodeTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual("abcdef", KataSortGiftCode.SortGiftCode("abcdef"));
                Assert.AreEqual("kpqsuvy", KataSortGiftCode.SortGiftCode("pqksuvy"));
                Assert.AreEqual("abcdefghijklmnopqrstuvwxyz",
                    KataSortGiftCode.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
            }
        }
    }
}