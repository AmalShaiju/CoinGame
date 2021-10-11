using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Wrappers;

namespace CoinGame
{
    public partial class PlayingField : Form
    {
        private List<Coin> LiveCoins = new List<Coin>();
        private CountDownTimer GameTimer = new CountDownTimer();
        private static CountDownTimer PowerUpTimer = new CountDownTimer();
        private int Points = 0;
        private int PlayerSpeed = 10;

        public PlayingField()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            pnlPlayer.Location = new Point(200, 200);
            GenerateCoin();

            // Game Timer
            GameTimer.SetTime(0, 20);
            GameTimer.Start();
            GameTimer.TimeChanged += () => lblGameTimer.Text = GameTimer.TimeLeftMsStr;
            GameTimer.StepMs = 1;
            GameTimer.CountDownFinished += () => HandleGameEnd();


            // Powerup timer
            PowerUpTimer.SetTime(0, 10);
            PowerUpTimer.Start();
            PowerUpTimer.IsRepeat = true;
            PowerUpTimer.TimeChanged += () => lblPowerUpTimer.Text = PowerUpTimer.TimeLeftMsStr;
            PowerUpTimer.CountDownFinished += () => GenerateCoin();
            GameTimer.StepMs = 1;

        }

        private void HandleGameEnd()
        {
            DialogResult dialogResult = MessageBox.Show($"New Highscore = {Points} \nWould you like to play again", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameReset();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
        private void GameReset()
        {
            Points = 0;
            PlayerSpeed = 10;
            LiveCoins.ForEach(p => Controls.Remove(p.CoinPanel));
            LiveCoins.Clear();
            GameTimer = new CountDownTimer();
            PowerUpTimer = new CountDownTimer();
            StartGame();
        }

        private void GenerateCoin()
        {
            Coin newCoin = new Coin();
            LiveCoins.Add(newCoin);
            Controls.Add(newCoin.CoinPanel);
        }

        private void RemoveCoin(Coin coin)
        {
            LiveCoins.Remove(coin);
            this.Controls.Remove(coin.CoinPanel);
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J || e.KeyCode == Keys.Left) //LEFT
            {
                int newX = (pnlPlayer.Location.X - PlayerSpeed >= 0) ? pnlPlayer.Location.X - PlayerSpeed : 0;
                pnlPlayer.Location = new Point(newX, pnlPlayer.Location.Y);
            }
            else if (e.KeyCode == Keys.I || e.KeyCode == Keys.Up) //UP
            {
                int newY = (pnlPlayer.Location.Y - PlayerSpeed >= 0) ? pnlPlayer.Location.Y - PlayerSpeed : 0;
                pnlPlayer.Location = new Point(pnlPlayer.Location.X, newY);
            }
            else if (e.KeyCode == Keys.L || e.KeyCode == Keys.Right) //RIGHT
            {
                int newX = (pnlPlayer.Location.X + PlayerSpeed <= 400) ? pnlPlayer.Location.X + PlayerSpeed : 400;
                pnlPlayer.Location = new Point(newX, pnlPlayer.Location.Y);
            }
            else if (e.KeyCode == Keys.K || e.KeyCode == Keys.Down) //DOWN
            {
                int newY = (pnlPlayer.Location.Y + PlayerSpeed <= 400) ? pnlPlayer.Location.Y + PlayerSpeed : 400;
                pnlPlayer.Location = new Point(pnlPlayer.Location.X, newY);
            }
            else return;

            DidPlayerInstersect();
        }

        private void DidPlayerInstersect()
        {
            Coin intersectedCoin = null;
            LiveCoins.ForEach(p =>
            {
                if (pnlPlayer.Bounds.IntersectsWith(p.CoinPanel.Bounds))
                {
                    intersectedCoin = p;
                    return;
                }
            });

            if (intersectedCoin != null)
                HandleIntersection(intersectedCoin);
        }

        private void HandleIntersection(Coin intersectedCoin)
        {
            CoinBuff coinBuff = intersectedCoin.coinType.CoinBuff;
            if (coinBuff == CoinBuff.Money)
            {
                Points += 10;
                this.lblPoints.Text = Points.ToString();
            }
            else if (coinBuff == CoinBuff.SlowMotion)
            {
                if (PlayerSpeed - 5 > 0)
                {
                    lblPowerUpMsg.Text = "Slow Motion";

                    PlayerSpeed = PlayerSpeed - 1;
                }
            }
            else if (coinBuff == CoinBuff.Accelaration)
            {
                if (PlayerSpeed + 3 <= 20)
                {
                    lblPowerUpMsg.Text = "Accelaration";
                    PlayerSpeed = PlayerSpeed + 1;
                }

            }
            else if (coinBuff == CoinBuff.Time)
            {
                lblPowerUpMsg.Text = "Time";
                GameTimer.Reset();
                GameTimer.Start();
            }

            RemoveCoin(intersectedCoin);
            GenerateCoin();
        }


    }

}
