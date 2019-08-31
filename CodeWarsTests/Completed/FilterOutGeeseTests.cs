using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FilterOutGeeseTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "Mallard", "Hook Bill", "Crested", "Blue Swedish" },
                FilterOutGeese.GooseFilter(new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" }));

            Assert.AreEqual(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" },
                FilterOutGeese.GooseFilter(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" }));

            Assert.AreEqual(new string[] { },
                FilterOutGeese.GooseFilter(new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" }));
        }
    }
}