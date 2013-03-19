using System.Linq;
using NUnit.Framework;

namespace CoinChanger1
{
    [TestFixture]
    public class CoinChangerTest
    {
        [Test]
        public void In1_Out1()
        {
            var amount = 1;
            var expectedCount = 1;
            var actual = CoinChanger.Change(amount);
            Assert.AreEqual(expectedCount, actual.Count());
            Assert.AreEqual(amount, actual.Sum());

        }
    }
}