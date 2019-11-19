using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BasicSubclassesAdamAndEveTests
    {
        [Test]
        public void SampleTest()
        {
            Human[] humans = God.Create();
            Assert.That(humans[0] is Man, "The first object in the array should be a Man");
        }
    }
}