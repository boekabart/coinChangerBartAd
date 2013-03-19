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

        public static IEnumerable<int> Change(int amount)
        {
            foreach (var coin in ExistingCoins)
            {
                if (amount >= coin)
                    return new[] {coin}.Concat(Change(amount - coin));
            }
            return new int[] {};
        }
    }
}