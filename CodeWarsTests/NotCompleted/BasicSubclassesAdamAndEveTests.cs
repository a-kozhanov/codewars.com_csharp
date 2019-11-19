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
            BasicSubclassesAdamAndEve.Human[] humans = BasicSubclassesAdamAndEve.Create();
            Assert.That(humans[0] is BasicSubclassesAdamAndEve.Man, "The first object in the array should be a Man");
        }
    }
}