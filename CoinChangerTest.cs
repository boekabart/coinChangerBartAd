using System.Linq;
using NUnit.Framework;

namespace CoinChanger1
{
    [TestFixture]
    public class CoinChangerTest
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 1)]
        [TestCase(10, 1)]
        [TestCase(20, 1)]
        [TestCase(11, 2)]
        [TestCase(21, 2)]
        [TestCase(14, 2)]
        [TestCase(24, 3)]
        [TestCase(12, 2)]
        public void In1_Out1(int amount, int expectedCount)
        {
            var actual = CoinChanger.Change(amount);
            Assert.AreEqual(expectedCount, actual.Count());
            Assert.AreEqual(amount, actual.Sum());
        }
    }
}
