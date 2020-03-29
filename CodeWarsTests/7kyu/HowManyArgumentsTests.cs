using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyArgumentsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(3, HowManyArguments.CountArgs(1, 2, 3));
            Assert.AreEqual(3, HowManyArguments.CountArgs(1, 2, "uhsaf uas"));
            Assert.AreEqual(1, HowManyArguments.CountArgs(1));

            Assert.AreEqual(4,
                HowManyArguments.CountArgs('a', 865, "asfhgajsf", new object[] {"dawdjio", null, new List<object>()}));

            Assert.AreEqual(0, HowManyArguments.CountArgs());
        }
    }
}