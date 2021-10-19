using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private CountDownTimer moveTimer = new CountDownTimer();

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

        public void MoveCoin()
        {
            // TODO: Fix bug -> balls keep vibrating if timer is not disposed
            moveTimer.Dispose();
            moveTimer = new CountDownTimer();
            Random rand = new Random();
            int newX = rand.Next(50, 400);
            int newY = rand.Next(50, 380);
            moveTimer.SetTime(0, 5);
            moveTimer.StepMs = 10;
            moveTimer.TimeChanged += () => Travel(newX, newY);
            moveTimer.CountDownFinished += () => MoveCoin(); // keep moving even if timer ran out and travel was not complete
            moveTimer.Start();
        }

        private void Travel(int newX, int newY)
        {
            if (CoinPanel.Location.X != newX)
            {
                if (CoinPanel.Location.X > newX)
                    CoinPanel.Location = new Point(CoinPanel.Location.X - 1, CoinPanel.Location.Y);
                else if (CoinPanel.Location.X < newX)
                    CoinPanel.Location = new Point(CoinPanel.Location.X + 1, CoinPanel.Location.Y);
            }

            if (CoinPanel.Location.Y != newY)
            {
                if (CoinPanel.Location.Y > newY)
                    CoinPanel.Location = new Point(CoinPanel.Location.X, CoinPanel.Location.Y - 1);
                else if (CoinPanel.Location.Y < newY)
                    CoinPanel.Location = new Point(CoinPanel.Location.X, CoinPanel.Location.Y + 1);
            }

            if (CoinPanel.Location.X == newX && CoinPanel.Location.Y == newY)
            {
                MoveCoin();
            }
        }


    }


}
