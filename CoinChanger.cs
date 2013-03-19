using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChanger1
{
    public class CoinChanger
    {
        private static readonly int[] ExistingCoins = new[] {20, 10, 5, 2, 1};
        public static int[] Change(int amount)
        {
            if (amount>ExistingCoins[0])
                return new[] { 1, ExistingCoins[0] };
            return new[] { amount };
        }
    }
}
