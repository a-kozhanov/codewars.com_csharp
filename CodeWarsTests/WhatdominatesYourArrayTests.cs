using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhatdominatesYourArrayTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, WhatdominatesYourArray.WhoDominates(new int[] {3, 4, 3, 2, 3, 1, 3, 3}));
            Assert.AreEqual(-1, WhatdominatesYourArray.WhoDominates(new int[] {1, 2, 3, 4, 5}));
            Assert.AreEqual(-1, WhatdominatesYourArray.WhoDominates(new int[] {1, 1, 1, 2, 2, 2}));
            Assert.AreEqual(2, WhatdominatesYourArray.WhoDominates(new int[] {1, 1, 1, 2, 2, 2, 2}));
        }
    }
}