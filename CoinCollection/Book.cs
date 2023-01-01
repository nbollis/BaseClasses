using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection
{
    public class Book
    {
        public BookType BookType { get; }
        public List<Coin> Coins { get; }
        public IEnumerable<Coin> MissingCoins => Coins.Where(p => !p.Have);
        public IEnumerable<Coin> AcquiredCoins => Coins.Where(p => p.Have);
        public double CompletionPercentage => Math.Round((double)AcquiredCoins.Count() / Coins.Count * 100, 0);

        public Book(BookType bookType, List<Coin> coins)
        {
            BookType = bookType;
            Coins = coins;
        }
    }
}
