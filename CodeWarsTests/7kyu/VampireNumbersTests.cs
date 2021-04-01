using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VampireNumbersTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(true, VampireNumbers.vampire_test(21, 6), "Basic: 21 * 6 = 126 should return True");
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(true, VampireNumbers.vampire_test(204, 615),
                "Basic: 204 * 615 = 125460 should return True");
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(true, VampireNumbers.vampire_test(30, -51),
                "One Negative: 30 * -51 = -1530 should return True");
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual(false, VampireNumbers.vampire_test(-246, -510),
                "Double Negatives: -246 * -510 = 125460 should return False (The negative signs aren't present on the product)");
        }

        [Test]
        public void test5()
        {
            Assert.AreEqual(true, VampireNumbers.vampire_test(210, 600),
                "Trailing Zeroes: 210 * 600 = 126000 should return True");
        }
    }
}