using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
        [TestFixture]
        class CenturyFromYearTests
        {
            private int check(int year)
            {
                return year % 100 == 0 ? year / 100 : year / 100 + 1;
            }

            [Test]
            public void BasicTest()
            {
                Assert.AreEqual(21, CenturyFromYear.centuryFromYear(2018));
                Assert.AreEqual(15, CenturyFromYear.centuryFromYear(1455));
                Assert.AreEqual(18, CenturyFromYear.centuryFromYear(1703));
                Assert.AreEqual(18, CenturyFromYear.centuryFromYear(1800));
            }

            [Test]
            public void RandomTest()
            {
                Random rnd = new Random();
                for (int i = 0; i < 100; i++)
                {
                    int n = rnd.Next(100, 1000000);
                    Assert.That(CenturyFromYear.centuryFromYear(n), Is.EqualTo(check(n)));
                }

            }
        }
}
