using System.Linq;
using NUnit.Framework;

namespace CoinChanger1
{
    [TestFixture]
    public class CoinChangerTest
    {
        [Test]
        [TestCase(1,1)]
        public void In1_Out1( int amount, int expectedCount)
        {
            var actual = CoinChanger.Change(amount);
            Assert.AreEqual(expectedCount, actual.Count());
            Assert.AreEqual(amount, actual.Sum());
        }
    }
}
