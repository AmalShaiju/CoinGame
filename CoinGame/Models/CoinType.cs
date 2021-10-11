using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum CoinBuff
    {
        SlowMotion,
        Accelaration,
        Money,
        Time,
    }

    public class CoinType
    {
        public CoinBuff CoinBuff;
        public string DisplayLetter;
        public Color Color;

        public CoinType()
        {

        }

        public CoinType(Color color, string displayLetter, CoinBuff coinBuff)
        {
            this.Color = color;
            this.DisplayLetter = displayLetter;
            this.CoinBuff = coinBuff;
        }

        private static List<CoinType> coinTypes = new List<CoinType>() {
            new CoinType( Color.AliceBlue, "S",CoinBuff.SlowMotion),
            new CoinType( Color.Red,"A",CoinBuff.Accelaration),
            new CoinType(Color.Green,"$",CoinBuff.Money),
            new CoinType(Color.Yellow,"T",CoinBuff.Time),
         };

        public CoinType GetRandomCoinType()
        {
            Random rand = new Random();
            return coinTypes[rand.Next(0, coinTypes.Count)];
        }

    }
}
