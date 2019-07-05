using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class YouOnlyNeedOneBeginnerTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, YouOnlyNeedOneBeginner.Check(new object[] { 66, 101 }, 66));
            Assert.AreEqual(true, YouOnlyNeedOneBeginner.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));

            Assert.AreEqual(true, YouOnlyNeedOneBeginner.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            Assert.AreEqual(false, YouOnlyNeedOneBeginner.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
    }
}