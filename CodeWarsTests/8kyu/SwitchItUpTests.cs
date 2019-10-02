using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SwitchItUpTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("One", KataSwitchItUp.SwitchItUp(1));
            Assert.AreEqual("Three", KataSwitchItUp.SwitchItUp(3));
            Assert.AreEqual("Five", KataSwitchItUp.SwitchItUp(5));
        }

        [Test]
        public void RandomTests()
        {
            var rand = new Random();
            Func<int, string> mySwitchItUp = delegate (int number)
            {
                switch (number)
                {
                    case 1: return "One";
                    case 2: return "Two";
                    case 3: return "Three";
                    case 4: return "Four";
                    case 5: return "Five";
                    case 6: return "Six";
                    case 7: return "Seven";
                    case 8: return "Eight";
                    case 9: return "Nine";
                }

                return "Zero";
            };

            for (var i = 0; i < 97; i++)
            {
                var a = rand.Next(0, 10);
                Assert.AreEqual(mySwitchItUp(a), KataSwitchItUp.SwitchItUp(a));
            }
        }
    }
}