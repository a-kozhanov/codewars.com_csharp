using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertLinkedListToStringTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("1 -> 2 -> 3 -> null",
                ConvertLinkedListToString.Stringify(new ConvertLinkedListToString.Node(1,
                    new ConvertLinkedListToString.Node(2, new ConvertLinkedListToString.Node(3)))));
            
            Assert.AreEqual("0 -> 1 -> 4 -> 9 -> 16 -> null",
                ConvertLinkedListToString.Stringify(new ConvertLinkedListToString.Node(0,
                    new ConvertLinkedListToString.Node(1,
                        new ConvertLinkedListToString.Node(4,
                            new ConvertLinkedListToString.Node(9, new ConvertLinkedListToString.Node(16)))))));
            Assert.AreEqual("null", ConvertLinkedListToString.Stringify(null));
        }
    }
}