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
        public List<ICoin> Coins { get; }

        public Book(BookType bookType, List<ICoin> coins)
        {
            BookType = bookType;
            Coins = coins;
        }
    }
}
