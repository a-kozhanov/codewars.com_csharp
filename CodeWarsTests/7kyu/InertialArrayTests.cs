using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InertialArrayTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, InertialArray.IsInertial(new int[] {11, 4, 20, 9, 2, 8}));
        }
    }
}