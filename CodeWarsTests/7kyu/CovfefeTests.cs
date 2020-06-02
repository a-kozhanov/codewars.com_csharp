using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataCovfefeTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("covfefe", KataCovfefe.Covfefe("coverage"));
            Assert.AreEqual("covfefe covfefe", KataCovfefe.Covfefe("coverage coverage"));
            Assert.AreEqual("nothing covfefe", KataCovfefe.Covfefe("nothing"));
            Assert.AreEqual("double space  covfefe", KataCovfefe.Covfefe("double space "));
            Assert.AreEqual("covfefe covfefe", KataCovfefe.Covfefe("covfefe"));
            Assert.AreEqual(" covfefe", KataCovfefe.Covfefe(""));
        }
    }
}