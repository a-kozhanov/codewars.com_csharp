using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataZebulansNightmareTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("camelCase", KataZebulansNightmare.ZebulansNightmare("camel_case"));
            Assert.AreEqual("markAsIssue", KataZebulansNightmare.ZebulansNightmare("mark_as_issue"));
            Assert.AreEqual("copyPastePep8", KataZebulansNightmare.ZebulansNightmare("copy_paste_pep8"));
            Assert.AreEqual("gotoNextKata", KataZebulansNightmare.ZebulansNightmare("goto_next_kata"));
            Assert.AreEqual("repeat", KataZebulansNightmare.ZebulansNightmare("repeat"));
            Assert.AreEqual("trollingIsFun", KataZebulansNightmare.ZebulansNightmare("trolling_is_fun"));
            Assert.AreEqual("why", KataZebulansNightmare.ZebulansNightmare("why"));
            Assert.AreEqual("123AbcDef", KataZebulansNightmare.ZebulansNightmare("123_abc_def"));
        }
    }
}