using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection
{
    public class Book
    {
        public string Name { get;}
        public BookType BookType { get; }
        public List<Coin> Coins { get; }
        public double CoinCount => Coins.Count;
        public IEnumerable<Coin> MissingCoins => Coins.Where(p => !p.Have);
        public double MissingCoinsCount => MissingCoins.Count();
        public IEnumerable<Coin> AcquiredCoins => Coins.Where(p => p.Have);
        public double AcquiredCoinsCount => AcquiredCoins.Count();
        public double CompletionPercentage => Math.Round(AcquiredCoinsCount / CoinCount * 100, 0);

        public Book(string name, BookType bookType, List<Coin> coins)
        {
            Name = name;
            BookType = bookType;
            Coins = coins;
        }

        public override string ToString()
        {
            return Name + " " + CompletionPercentage;
        }
    }
}
