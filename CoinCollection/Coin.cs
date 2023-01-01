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

        public string? SpecialtyInfo { get; }

        public Coin(CoinType coinType, MintLocation mint, double year, bool have, string? specInfo = null)
        {
            CoinType = coinType;
            Mint = mint;
            Year = year;
            Have = have;
            SpecialtyInfo = specInfo;
        }

        public void AddToCollection()
        {
            Have = true;
        }
    }
}
