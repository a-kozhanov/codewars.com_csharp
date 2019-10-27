using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DalmatiansSquashTests
    {
        [Test]
        public void BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("More than a handful!", DalmatiansSquash.HowManyDalmatians(26));
            StringAssert.AreEqualIgnoringCase("Hardly any", DalmatiansSquash.HowManyDalmatians(8));
            StringAssert.AreEqualIgnoringCase("More than a handful!", DalmatiansSquash.HowManyDalmatians(14));
            StringAssert.AreEqualIgnoringCase("Woah that's a lot of dogs!", DalmatiansSquash.HowManyDalmatians(80));
            StringAssert.AreEqualIgnoringCase("Woah that's a lot of dogs!", DalmatiansSquash.HowManyDalmatians(100));
            StringAssert.AreEqualIgnoringCase("More than a handful!", DalmatiansSquash.HowManyDalmatians(50));
            StringAssert.AreEqualIgnoringCase("Hardly any", DalmatiansSquash.HowManyDalmatians(10));
            StringAssert.AreEqualIgnoringCase("101 DALMATIONS!!!", DalmatiansSquash.HowManyDalmatians(101));
        }
    }
}