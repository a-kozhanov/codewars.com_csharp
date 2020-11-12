using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BirthdayICakeTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("That was close!", BirthdayICake.Cake(900, "abcdef"));
            Assert.AreEqual("Fire!", BirthdayICake.Cake(56, "ifkhchlhfd"));
            Assert.AreEqual("Fire!", BirthdayICake.Cake(256, "aaaaaddddr"));
        }
    }
}