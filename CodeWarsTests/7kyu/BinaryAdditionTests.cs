using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BinaryAdditionTests
    {
        [TestFixture]
        public class AddBinaryTest
        {
            [Test]
            public void TestExample()
            {
                Assert.AreEqual("11", BinaryAddition.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
            }
        }
    }
}