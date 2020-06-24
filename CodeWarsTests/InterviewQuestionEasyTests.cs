using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InterviewQuestionEasyTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", InterviewQuestionEasy.GetStrings("Chicago"));
            Assert.AreEqual("b:*,a:*,n:*,g:*,k:**,o:*", InterviewQuestionEasy.GetStrings("Bangkok"));
            Assert.AreEqual("l:*,a:**,s:**,v:*,e:*,g:*", InterviewQuestionEasy.GetStrings("Las Vegas"));
        }
    }
}