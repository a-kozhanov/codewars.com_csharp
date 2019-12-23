using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowOldWillIbeIn2099Tests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("You are 17 years old.", HowOldWillIbeIn2099.CalculateAge(2003, 2020));
            Assert.AreEqual("You are 1 year old.", HowOldWillIbeIn2099.CalculateAge(2019, 2020));
            Assert.AreEqual("You were born this very year!", HowOldWillIbeIn2099.CalculateAge(2003, 2003));
            Assert.AreEqual("You will be born in 17 years.", HowOldWillIbeIn2099.CalculateAge(2020, 2003));      
            Assert.AreEqual("You will be born in 1 year.", HowOldWillIbeIn2099.CalculateAge(2020, 2019));
        }     
    }
}