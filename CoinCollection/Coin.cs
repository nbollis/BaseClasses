using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection
{
    public class Coin
    {
        public CoinType CoinType { get; }

        public MintLocation Mint { get; }

        public double Year { get; }

        public bool Have { get; private set; }

        public Coin(CoinType coinType, MintLocation mint, double year, bool have)
        {
            CoinType = coinType;
            Mint = mint;
            Year = year;
            Have = have;
        }

        public void AddToCollection()
        {
            Have = true;
        }
    }
}
