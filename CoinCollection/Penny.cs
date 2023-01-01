using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection
{
    public class Penny : Coin
    {
        public PennyType PennyType { get; }

        public Penny(PennyType type, MintLocation mint, double year, bool have) 
            : base(CoinType.Penny, mint, year, have)
        {
            PennyType = type;
        }
    }
}
