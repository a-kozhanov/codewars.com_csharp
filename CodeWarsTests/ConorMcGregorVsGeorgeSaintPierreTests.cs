using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConorMcGregorVsGeorgeSaintPierreTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("I am not impressed by your performance.", ConorMcGregorVsGeorgeSaintPierre.Quote("george saint pierre"));
            Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", ConorMcGregorVsGeorgeSaintPierre.Quote("conor mcgregor"));
            Assert.AreEqual("I am not impressed by your performance.", ConorMcGregorVsGeorgeSaintPierre.Quote("George Saint Pierre"));
            Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", ConorMcGregorVsGeorgeSaintPierre.Quote("Conor McGregor"));
        }
    }
}