using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinGame;
using Wrappers;

namespace Models
{
    public class Coin
    {
        private Panel onScreen;
        public CoinType coinType;
        public Panel CoinPanel
        {
            get { return onScreen; }
        }

        public Coin()
        {
            coinType = new CoinType();
            coinType = this.coinType.GetRandomCoinType();
            onScreen = new CirclePanel(coinType.Color, coinType.DisplayLetter);
            SetPanelLocation();
        }

        private void SetPanelLocation()
        {
            Random rand = new Random();
            CoinPanel.Location = new Point(rand.Next(50, 400), rand.Next(50, 380));
            CoinPanel.Height = 20;
            CoinPanel.Width = 20;
        }

    }


}
