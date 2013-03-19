using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChanger1
{
    public class CoinChanger
    {
        private static readonly int[] ExistingCoins = new[] {20, 10, 7, 5, 1};

        public static IEnumerable<int> Change(int amount)
        {
            if (amount == 0)
                return new int[0];
            var coinOptions = ExistingCoins.Where(coin => coin <= amount);
            var solutions = coinOptions.Select(coin =>
                                               TakeCoinAndRecurseRest(amount, coin)).ToArray();
            var solutionsByQuality = solutions.OrderBy(set => set.Length);
            return solutionsByQuality.First();
        }

        private static int[] TakeCoinAndRecurseRest(int amount, int coin)
        {
            return new[] {coin}.
                Concat(Change(amount - coin))
                               .ToArray();
        }
    }
}
